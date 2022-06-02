using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Verificacion
    {
        public List<bool> Checar(List<int> list,int c1,int c2,int c3)
        {
            List<bool> check = new List<bool>() { false, false, false };
            List<int> l = list;
            //Refrescos
            if(l[0] > 0 && l[0] <= 120)
            {
                if(c1 == 1)
                {
                    check[0] = true;
                }
            }else if (l[0] > 120 && l[0] <= 240)
            {
                if (c1 == 2)
                {
                    check[0] = true;
                }
            }
            else if(l[0] > 240)
            {
                if (c1 == 3)
                {
                    check[0] = true;
                }
            }
            //Panes
            if (l[1] > 0 && l[1] <= 270)
            {
                if (c2 == 1)
                {
                    check[1] = true;
                }
            }
            else if (l[1] > 270 && l[1] <= 540)
            {
                if (c2 == 2)
                {
                    check[1] = true;
                }
            }
            else if (l[1] > 540)
            {
                if (c2 == 3)
                {
                    check[1] = true;
                }
            }
            //Verdura
            if (l[2] > 0 && l[2] <= 95)
            {
                if (c3 == 1)
                {
                    check[2] = true;
                }
            }
            else if (l[2] > 95 && l[2] <= 190)
            {
                if (c3 == 2)
                {
                    check[2] = true;
                }
            }
            else if (l[2] > 190)
            {
                if (c3 == 3)
                {
                    check[2] = true;
                }
            }

            return check;
        }
    }
}
