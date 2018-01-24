using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Pan
    {
        private forcemeat[] forcemeat;

        private potato[] potatos;

        private Salt salt;

        private Pepper pepper;

        public bool State
        {
            set;
            get;
        }

        public bool ReadyToGo
        {
            get
            {
                return Check();
            }
        }

        public void Init2(int countForcemeat)
        {
            forcemeat = new forcemeat[countForcemeat];
        }

        public void Init(int countPotatos)
        {
           
            potatos = new potato[countPotatos];
        }

        public void AddForcemeat(forcemeat o)
        {
            for (int i = 0; i < forcemeat.Length; ++i)
            {
                if (forcemeat[i] == null)
                {
                    forcemeat[i] = o;
                    return;
                }
            }
        }

        public void AddSalt(Salt s)
        {
            salt = s;
        }

        public void AddPepper(Pepper p)
        {
            pepper = p;
        }

        public void AddPotato(potato potato)
        {
            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i] == null)
                {
                    potatos[i] = potato;
                    return;
                }
            }
        }

        private bool Check()
        {
            if (forcemeat.Length == 0)
            {
                return false;
            }
            
            if (potatos == null)
            {
                return false;
            }
            if (potatos.Length == 0)
            {
                return false;
            }
           
            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i] == null)
                {
                    return false;
                }
            }
            return true;
        }

        public void GetHeat()
        {
            if (!Check())
            {
                return;
            }
            if (forcemeat.Length > 0)
            {
                if (forcemeat[0].Temperature < 100)
                {
                    for (int i = 0; i < forcemeat.Length; ++i)
                    {
                        forcemeat[i].GetHeat();
                    }
                    bool flag = false;
                    switch (forcemeat[0].Temperature)
                    {
                        case 20: flag = true; break;
                        case 40: flag = true; break;
                        case 60: flag = true; break;
                        case 80: flag = true; break;
                        case 100: flag = true; break;
                    }
                    if (flag)
                    {
                        for (int i = 0; i < potatos.Length; ++i)
                        {
                            potatos[i].GetHeat();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < potatos.Length; ++i)
                    {
                        potatos[i].GetHeat();
                    }
                }
            }
        }

        public bool IsReady()
        {
            for (int i = 0; i < forcemeat.Length; ++i)
            {
                if (forcemeat[i].Temperature < 100)
                {
                    return false;
                }
            }
            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i].Has_ready < 10)
                {
                    return false;
                }
            }
            return true;
        }

        public potato[] GetPotatos()
        {
            return potatos;
        }
    }
}
