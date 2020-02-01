using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Forum1 : Form
    {
        private List<Hall> Halls = new List<Hall>();
        private List<Button> SelectedBtns = new List<Button>();
        private List<Book> Bookings = new List<Book>();
        private int Price = 5;
        private Hall SelectedHall;
        public Forum1()
        {
            InitializeComponent();
            AddHall();
        }
        private void AddHall()
        {
            Hall Hall1 = new Hall
            {
                SeatCount = 20,
                Column = 5
            };
            Hall Hall2 = new Hall
            {
                SeatCount = 16,
                Column = 4
            }; Hall Hall3 = new Hall
            {
                SeatCount = 9,
                Column = 3
            };
            this.Halls.Add(Hall1);
            this.Halls.Add(Hall2);
            this.Halls.Add(Hall3);
        }
        public void SelectHall_click(object sender,EventArgs e)
        {
            Button Clicked = sender as Button;           
            int HallIndex = Convert.ToInt32(Clicked.Name[Clicked.Name.Length - 1].ToString())-1;          
            this.GenerataSeats(HallIndex);
            SelectedHall = this.Halls[HallIndex];
        }
        private void GenerataSeats(int index)
        {
            ClearSeats();
          
            int x = 20;
            int y = 20;
            for (int i= 0; i < this.Halls[index].SeatCount; i++)
            {
                Button Btn = new Button();
               
                Btn.Size = new Size(40, 40);
                Btn.Text = (i + 1).ToString();
                Btn.Location = new Point(x, y);
                x += 65;
                Btn.Click += new EventHandler(this.AllSeats_Click);
                PnlSeats.Controls.Add(Btn);
                Btn.BackColor = Color.LightGray;

                if (this.Bookings.Exists(b => b.Hall == this.Halls[index] && b.SeatIndex == i))
                {
                    Btn.BackColor = Color.GreenYellow;
                }

                if ((i + 1) % this.Halls[index].Column == 0)
                {
                    y += 40;
                    x = 20;
                }
            }
        }

        private void ClearSeats()
        {
            PnlSeats.Controls.Clear();
        }
        private void AllSeats_Click(object sender, EventArgs e)
        {
            Button Clicked = sender as Button;
            if (Clicked.BackColor == Color.LightGray)
            {
                this.SelectedBtns.Add(Clicked);
                Clicked.BackColor = Color.Yellow;
            }
            else if(Clicked.BackColor == Color.Yellow)
            {
                this.SelectedBtns.Remove(Clicked);
                Clicked.BackColor = Color.LightGray;
            }
            else
            {
                DialogResult r = MessageBox.Show("Bu Bilet legv edilsin mi?", "legv edilsin", MessageBoxButtons.OKCancel);
                if (r==DialogResult.OK)
                {
                    Clicked.BackColor = Color.LightGray;

                    int index = this.Bookings.FindIndex(b => b.Hall == this.SelectedHall && b.SeatIndex == (Convert.ToInt32(Clicked.Text) - 1));
                    this.Bookings.RemoveAt(index);
                }
            }
            CalcTotal();
            SelectedPlaces();
            BtnReserv();
        }

        private void BtnReserv()
        {
            if (this.SelectedBtns.Count > 0)
            {
                BtnBook.Visible= true;
            }
            else
            {
                BtnBook.Visible = false;
            }
        }

      private void CalcTotal()
        {
            if (this.SelectedBtns.Count > 0)
            {
                LblTotalPrice.Text = (SelectedBtns.Count * Price).ToString() + "Azn";
            }
            else
            {
                LblTotalPrice.Text = " ";
            }
            
        }

        private void SelectedPlaces()
        {
            List<string> Place = new List<string>();
            foreach (Button button in this.SelectedBtns)
            {
                Place.Add(button.Text);
            }
            SelectedPlace.Text = string.Join(",", Place.ToArray());
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bu Bilet(ler) secilsin mi?", "Secilsin", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                foreach (Button button in SelectedBtns)
                {
                    button.BackColor = Color.GreenYellow;
                    Book Booking = new Book()
                    {
                        Hall = this.SelectedHall,
                        SeatIndex = Convert.ToInt32(button.Text)-1
                    };
                    this.Bookings.Add(Booking);

                }

                this.SelectedBtns.Clear();
                LblTotalPrice.Text = "";
                SelectedPlace.Text = "";
               
            }
         
        }
    }
}
