using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Threading;

namespace queue_01_wpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Queue<string> myQueue = new Queue<string>();
        public List<string> historyList = new List<string>();
        public DateTime myDate = DateTime.Now;
        string guestDetails = "{0,-25}{1,-27}{2,-15}{3,-15}";
        public DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

            RedrawListBox();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {

            RedrawListBox();

        }

        private void deQueueButton_Click(object sender, RoutedEventArgs e)
        {

            if (listBox1.Items.Count > 0)
            {

                //create entry for wait history box
                string guestDate = myQueue.Peek();

                string arrival = myQueue.Peek();

                string party = myQueue.Peek();

                string secondsString = listBox1.Items[0].ToString();
                secondsString = secondsString.Substring(75);
                secondsString = Regex.Match(secondsString, @"(?:[01]\d|2[0123]):(?:[012345]\d):(?:[012345]\d)").ToString();

                arrival = Regex.Match(arrival, @"((1[0-2]|0?[1-9]):([0-5][0-9]):([0-5][0-9]) ?([AaPp][Mm]))").ToString();
                party = Regex.Match(party, @"  \d\d?   ").ToString();

                historyBox.Items.Insert(0, arrival + "    " + party + "    " + secondsString);
                myQueue.Dequeue(); //Remove next guest to be seated

                //redraw listbox
                RedrawListBox();
            }
        }

        //button click to add the guest from textbox
        private void AddGuestButton_Click(object sender, RoutedEventArgs e)
        {

            using (NewGuestForm newGuestForm = new NewGuestForm())
            {
                if (newGuestForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int partySize = newGuestForm.newGuestpartySize;

                    myQueue.Enqueue(String.Format(guestDetails, DateTime.Now, newGuestForm.newGuestName, newGuestForm.newGuestPhone, partySize.ToString()));

                    RedrawListBox();
                }
            }
        }


        private void RedrawListBox()
        {
            listBox1.Items.Clear(); //empty listbox

            //redraw listbox
            for (int i = 0; i < myQueue.Count && myQueue.Count > 0; i++)
            {
                string guestDate = myQueue.ElementAt(i).ToString();
                guestDate = guestDate.Substring(0, 21);
                TimeSpan seconds = DateTime.Now - DateTime.Parse(guestDate);
                string secondsString = seconds.ToString(@"hh\:mm\:ss");

                listBox1.Items.Add(myQueue.ElementAt(i) + " " + secondsString);


            }
        }

        //private void ExitButton_Click(object sender, RoutedEventArgs e)
        //{
        //    Application.Current.Shutdown();
        //}

        //private void textBoxAddGuest_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.Enter)
        //    {
        //        e.Handled = true;
        //        AddGuest();
        //    }

        //}


    }
}
