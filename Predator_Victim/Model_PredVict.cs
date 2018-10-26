using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Predator_Victim
{
    public class Model_PredVict
    {
        public decimal R_V { get; set; }
        public decimal D_V { get; set; }
        public decimal D_P { get; set; }
        public decimal K_P { get; set; }
        public decimal G { get; set; }
        public decimal Victim_start { get; set; }
        public decimal Predator_start { get; set; }
        public decimal Predator_count { get; set; }
        public decimal Victim_count { get; set; }

        public Model_PredVict()
        {
        }

        public void Input_value(decimal r_v, decimal d_v, decimal d_p, decimal k_p, decimal g, decimal victim_start, decimal predator_start)
        {


            //рождаемость, смертность жертвы
            R_V = r_v / 1000;
           // R_V = r_v;
            D_V = d_v / 100000;
            //D_V = d_v;

            //смертность хищника, коэф.хищничества
            D_P = d_p / 1000;
            K_P = k_p / 1000000;

            //поколение
            G = g;

            //нач значение жертв
            Victim_start = victim_start;

            //нач значение хищников
            Predator_start = predator_start;

            //default
            Predator_count = 0;
            Victim_count = 0;
        }
        
        public void Calc_count()
        {


            Predator_count = Predator_start + (K_P * Predator_start * Victim_start) - (D_P * Predator_start);
            Victim_count = Victim_start + (R_V * Victim_start) - (D_V * Victim_start * Predator_start); 
       
            Predator_start = Math.Round(Predator_count);
            Victim_start = Math.Round(Victim_count);
        }
    }
    
}