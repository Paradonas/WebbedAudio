using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Threading;
using WebbedAudio.Core.Models;
using System.Windows.Media;

namespace WebbedAudio.Core
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string MediaPlayerState;
        public (string, string, string, string, string, string, TimeSpan) trackInfo;
        public bool isChangingTrackTime = false,
                    isChangingVolume = false;
        public string Directory;
        public string urlTextColor = "#BBBBBBBB";

        public MainWindow()
        {
            InitializeComponent();

            Directory = @$"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}/../../../";
            AudioFile firstFile = new AudioFile();

            firstFile.FileName = "Scar Tissue";
            firstFile.FileDate = new DateOnly(2003, 5, 8);
            firstFile.FileType = ".mp3";
            firstFile.FileSize = "7 kB";

            FilesDataGrid.Items.Add(firstFile);

            for (int i = 0; i < 25; i++)
            {
                FilesDataGrid.Items.Add(new AudioFile()
                {
                    FileName = $"File {i}",
                    FileDate = DateOnly.FromDateTime(DateTime.Now.AddDays(i)),
                    FileSize = $"{i} kB",
                    FileType = ".mp3"
                });
            }
        }

        //Minimize Click to minimize app
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }

        //Cross Click to exit app
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //Execures when MediaElement or MainPlayer is loaded with a new song.
        private void MediaElement_Loaded(object sender, RoutedEventArgs e)
        {
            //Initializes a DisptachTimer which executes assigned EventHandler on Interval.
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(DispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

            trackInfo = GetTrackInfo();

            //trackInfo is initialized
            AuthorText.Text = trackInfo.Item1;
            AlbumText.Text = trackInfo.Item2;
            YearText.Text = trackInfo.Item3;
            GenreText.Text = trackInfo.Item4;
            NumberText.Text = trackInfo.Item5;
            TitleText.Text = trackInfo.Item6;

            //TrackTimeSlider is updated to match current track
            TrackTimeSlider.Minimum = 0;
            TrackTimeSlider.Maximum = trackInfo.Item7.TotalSeconds;
            TrackTimeSlider.IsSnapToTickEnabled = true;

            //Starts the song upon load for fewer clicks
            MainPlayer.Play();
            MediaPlayerState = "Play";

            VolumeSlider.Value = MainPlayer.Volume;
        }

        
        //Pause button click. Compares to changing string to know which is the current action to execute.
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (MediaPlayerState == "Play")
            {
                MainPlayer.Pause();
                MediaPlayerState = "Pause";
            }
            else if (MediaPlayerState == "Pause")
            {
                MainPlayer.Play();
                MediaPlayerState = "Play";
            }
        }

        //DispatcherTimer ticks and executes every second. 
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {

            //Displays Elapsed Time and Total Time (ElapsedTrackTime / TotalTrackTime). Strings are formatted for minutes and seconds from TimeSpan objects of:
            //MainPlayer.Position which is the mediaplayers current position and the current tracks length from trackInfo Tuple.
            TrackTimeDisplay.Text = $"{String.Format("{0:mm}:{0:ss}", MainPlayer.Position)} / {String.Format("{0:mm}:{0:ss}", trackInfo.Item7)}";

            //Allows for user to change the Track Position. This is done through a bool disabling the TrackTimeThumb part of the TrackTimeSlider from following its value temporarily then
            //reengaging the indicator once the key or mouse has been released. 
            if (!isChangingTrackTime)
                TrackTimeSlider.Value = MainPlayer.Position.TotalSeconds;
        }

        public (string, string, string, string, string, string, TimeSpan) GetTrackInfo()
        {
            //TagLib is a NuGet Package that makes file properties easier to access. Here its diffrent audio files.

            TagLib.File tagFile = TagLib.File.Create("../../../Tracks/Uncategorized Downloads/Red Hot Chili Peppers - Scar Tissue [Official Music Video].mp3");
            List<string> tempList = new List<string>();

            //0 FirstPerformer, 1 Album, 2 Year, 3 FirstGenre, 4 Track, 5 Title, 6 TotalTrackTime
            return (
            (tagFile.Tag.FirstPerformer),
            (tagFile.Tag.Album),
            (tagFile.Tag.Year.ToString()),
            (tagFile.Tag.FirstGenre),
            (tagFile.Tag.Track.ToString()),
            (tagFile.Tag.Title),
            (new TimeSpan(0, tagFile.Properties.Duration.Minutes, tagFile.Properties.Duration.Seconds))
            );

        }

        //Resets Track Position to 0 / Restarts the track.

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainPlayer.Position = new TimeSpan(0);
        }

        //Allows for user to change the Track Position. This is done through a bool disabling the TrackTimeThumb part of the TrackTimeSlider from following its value temporarily then
        //reengaging the indicator once the key or mouse has been released.

        //MouseClick

        private void TrackTimeSlider_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isChangingTrackTime = true;
        }

        private void TrackTimeSlider_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainPlayer.Position = new TimeSpan(0, 0, (int)TrackTimeSlider.Value);
            isChangingTrackTime = false;
        }

        //MouseDrag

        private void TrackTimeSlider_DragStarted(object sender, DragStartedEventArgs e)
        {
            isChangingTrackTime = true;
        }

        private void TrackTimeSlider_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            MainPlayer.Position = new TimeSpan(0, 0, (int)TrackTimeSlider.Value);
            isChangingTrackTime = false;
        }

        //KeyPress, Does not really work yet

        private void TrackTimeSlider_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right || e.Key == Key.Left || e.Key == Key.A || e.Key == Key.D)
                isChangingTrackTime = true;
        }

        private void TrackTimeSlider_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right || e.Key == Key.Left || e.Key == Key.A || e.Key == Key.D)
            {
                MainPlayer.Position = new TimeSpan(0, 0, (int)TrackTimeSlider.Value);
                isChangingTrackTime = false;
            }
        }

        private void VolumeSlider_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            MainPlayer.Volume = VolumeSlider.Value;
            AuthorText.Text = VolumeSlider.Value.ToString();
            GenreText.Text = MainPlayer.Volume.ToString();
        }

        private void Slider_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainPlayer.Volume = VolumeSlider.Value;
        }

        //Navigation Clicks

        private void HomeNav_Click(object sender, RoutedEventArgs e)
        {
            HomePane.Visibility = Visibility.Visible;
            TracksPane.Visibility = Visibility.Collapsed;
            GetPane.Visibility = Visibility.Collapsed;
        }

        private void TracksNav_Click(object sender, RoutedEventArgs e)
        {
            TracksPane.Visibility = Visibility.Visible;
            HomePane.Visibility = Visibility.Collapsed;
            GetPane.Visibility= Visibility.Collapsed;
        }

        private void GetNav_Click(object sender, RoutedEventArgs e)
        {
            GetPane.Visibility = Visibility.Visible;
            TracksPane.Visibility= Visibility.Collapsed;
            HomeNav.Visibility = Visibility.Collapsed;
        }

        // Placeholder url link
        private void urlText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (urlText.Text == "")
            {
                urlTextColor = "#BBBBBBBB";
                urlText.Text = "Enter url here 'https://fulllengthaudiobooks.com/patrick-ness-the-ask-and-the-answer-audiobook/'";
            }
            else
            {
                urlTextColor = "#EEEEEEEE";
            }
        }

        private void urlText_LostFocus(object sender, RoutedEventArgs e)
        {
            if (urlText.Text == "Enter url here 'https://fulllengthaudiobooks.com/patrick-ness-the-ask-and-the-answer-audiobook/'")
                urlText.Text = "";
        }



        //Tracks- / Files Pane

        private void OpenFileExplorerButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName;

            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();

            openFileDialog.Filter = "MP3 Files (*.mp3)| *.mp3 | WAW Files (*.waw)| *.wav| WAV Files (*.wav)| *.wav| WMA Files (*.wma)| *.wma| AAC Files (*.aac)| *.aac| OGG Files (*.ogg)| *.ogg";
            openFileDialog.Multiselect = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.InitialDirectory = $"{Directory}";

            Nullable<bool> result = openFileDialog.ShowDialog();

            if (result == true)
            {
                fileName = openFileDialog.FileName;  
            }
        }
    }
}
