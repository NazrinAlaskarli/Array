using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Gun
    {
        //private string CurrentBullet;
        public int MaxBullet { get; set; }


        public int CurrentBullet { get; set; }

        public void Fire()
        {
            while (CurrentBullet>0)
            {
                Console.WriteLine(CurrentBullet);
                CurrentBullet--; 
            }
            Console.WriteLine("Gulle bitdi");
        } 



        public void Relaod()
        {
            CurrentBullet = MaxBullet;  
        }
    }

}
