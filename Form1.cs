using System;
using System.Windows.Forms;

namespace wf324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBarTime_Scroll(object sender, EventArgs e)
        {
            CalculateDistance();
        }

        private void CalculateDistance()
        {
            try
            {
                double speed = double.Parse(txtSpeed.Text);
                double time = trackBarTime.Value;
                double distance = speed * time;

                lblDistance.Text = "Расстояние: " + Math.Round(distance, 2) + " км";
            }
            catch (FormatException)
            {
                lblDistance.Text = "Расстояние: Введено некорректное значение скорости";
            }
            catch (Exception ex)
            {
                lblDistance.Text = "Расстояние: Произошла ошибка!: " + ex.Message;
            }
        }
    }
}