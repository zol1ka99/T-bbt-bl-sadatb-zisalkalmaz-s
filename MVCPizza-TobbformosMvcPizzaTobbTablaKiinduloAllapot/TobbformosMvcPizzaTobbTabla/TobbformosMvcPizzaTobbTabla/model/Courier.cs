using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Model
{
    partial class Courier
    {
        private int id;
        private string name;
        private string tel;

        public Courier(int id, string name, string tel)
        {
            this.id = id;
            this.name = name;
            this.tel = tel;

            if (!isValidName(name))
            {
                throw new ModelFutarNotValidNameExeption("A futár neve nem megfelelő (nagy betűvel kell kezdeni a nevet) !");
            }

            if (!isValidTel(tel))
            {
                throw new ModelFutarNotValidNameExeption("A telefonszám nem megfelelő (pl: +36705462345) !");
            }
        }

        public bool isValidName(string name)
        {
            if (name == string.Empty)
            {
                return false;
            }

            if (!char.IsUpper(name.ElementAt(0)))
            {
                return false;
            }

            for (int i = 1; i < name.Length; i++)
            {
                if ((!char.IsLetter(name.ElementAt(i))) && (!char.IsWhiteSpace(name.ElementAt(i))))
                {
                    return false;
                }
            }
            return true;
        }

        public bool isValidTel(string telefonNumber)
        {
            if (telefonNumber.Length != 12)
            {
                return false;
            }
            else
            {
                if (telefonNumber[0] == '+')
                {
                    if (telefonNumber[1] == '3')
                    {
                        if (telefonNumber[2] == '6')
                        {
                            if (char.IsDigit(telefonNumber[3]))
                            {
                                if (char.IsDigit(telefonNumber[4]))
                                {
                                    if (char.IsDigit(telefonNumber[5]))
                                    {
                                        if (char.IsDigit(telefonNumber[6]))
                                        {
                                            if (char.IsDigit(telefonNumber[7]))
                                            {
                                                if (char.IsDigit(telefonNumber[8]))
                                                {
                                                    if (char.IsDigit(telefonNumber[9]))
                                                    {
                                                        if (char.IsDigit(telefonNumber[10]))
                                                        {
                                                            if (char.IsDigit(telefonNumber[11]))
                                                            {
                                                                return true;
                                                            }
                                                            else
                                                            {
                                                                return false;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            return false;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        return false;
                                                    }
                                                }
                                                else
                                                {
                                                    return false;
                                                }
                                            }
                                            else
                                            {
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setTel(string tel)
        {
            this.tel = tel;
        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public string getTel()
        {
            return tel;
        }

        public void update(Courier modified)
        {
            this.name = modified.getName();
            this.tel = modified.getTel();
        }
    }
}
