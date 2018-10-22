using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace Predator_Victim
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public bool checkPoint;
        Model_PredVict model = new Model_PredVict();

        public void TextBox_clear()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Форматировать диаграмму
            Chart1.BackColor = Color.Gray;
            Chart1.BackSecondaryColor = Color.WhiteSmoke;
           Chart1.BackGradientStyle = GradientStyle.DiagonalRight;

            Chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            Chart1.BorderlineColor = Color.Gray;
            Chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

             //Форматировать область диаграммы
            Chart1.ChartAreas[0].BackColor = Color.Wheat;

             //Добавить и форматировать заголовок
            Chart1.Titles.Add("Модель хищник-жертва");
           Chart1.Titles[0].Font = new Font("Utopia", 16);
        }

        protected void Chart1_Load(object sender, EventArgs e)
        {
            //Chart1.ChartAreas[0].AxisY.Minimum = 0;
            //Chart1.ChartAreas[0].AxisY.Maximum = 10000;

            //Chart1.ChartAreas[0].AxisX.Minimum = 0;
            //Chart1.ChartAreas[0].AxisX.Maximum = 219;

           
        }

        public bool Check_value()
        {
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "" && TextBox7.Text != "")
            
                return true;
            
            else

                return false;
        }

        public void Input_default_values()
        {
            TextBox1.Text = "100";
            TextBox2.Text = "300";
            TextBox3.Text = "70";
            TextBox4.Text = "80";
            TextBox5.Text = "5";
            TextBox6.Text = "500";
            TextBox7.Text = "50";
        }

    

        protected void Button1_Click(object sender, EventArgs e)
        {
            checkPoint = Check_value();
            if (checkPoint == true)
            {
                model.Input_value(float.Parse(TextBox1.Text), float.Parse(TextBox2.Text), float.Parse(TextBox3.Text), float.Parse(TextBox4.Text), float.Parse(TextBox5.Text), float.Parse(TextBox6.Text), float.Parse(TextBox7.Text));


                Chart1.Series[0].ChartType = System.Web.UI.DataVisualization.Charting.SeriesChartType.Spline;
                Chart1.Series[1].ChartType = System.Web.UI.DataVisualization.Charting.SeriesChartType.Spline;

                Chart1.Series[0].Points.AddXY(0, model.Victim_start);
                Chart1.Series[1].Points.AddXY(0, model.Predator_start);

                model.Calc_count();

                for (int i = 0; i < model.G; i++)
                {
                    Chart1.Series[0].Points.AddXY(i +1, model.Victim_count);
                    Chart1.Series[1].Points.AddXY(i +1, model.Predator_count);

                    model.Calc_count();
                }
            }
            else
                TextBox1.Text = "error_value";
                
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox_clear();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Input_default_values();
        }
    }
}