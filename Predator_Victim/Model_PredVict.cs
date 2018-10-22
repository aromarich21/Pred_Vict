using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Predator_Victim
{
    public class Model_PredVict
    {
        public float R_V { get; set; }
        public float D_V { get; set; }
        public float D_P { get; set; }
        public float K_P { get; set; }
        public float G { get; set; }
        public float Victim_start { get; set; }
        public float Predator_start { get; set; }
        public float Predator_count { get; set; }
        public float Victim_count { get; set; }

        public Model_PredVict()
        {
        }

        public Model_PredVict(float r_v, float d_v, float d_p, float k_p, float g, float victim_start, float predator_start)
        {
            //рождаемость, смертность жертвы
            R_V = r_v / 1000;
            D_V = d_v / 100000;

            //смертность хищника, коэф.хищничества
            D_P = d_p / 1000;
            K_P = k_p / 100000;

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

        public void Input_value(float r_v, float d_v, float d_p, float k_p, float g, float victim_start, float predator_start)
        {
            

            //рождаемость, смертность жертвы
                R_V = r_v / 1000;
             D_V = d_v / 100000;

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

           
            Predator_count = Predator_start + K_P * Predator_start * Victim_start - D_P * Predator_start;
                Victim_count = Victim_start + R_V * Victim_start - D_V * Victim_start * Predator_start;
                //Victim_count = R_V * Victim_start - K_P * Victim_start * Predator_start;
                //Predator_count = -(D_P * Predator_start) + D_V * Predator_start * Victim_start;

                Predator_start = Predator_count;
                Victim_start = Victim_count;
        }
    }
    
}