using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace DiscordFlooder.Class.Design.Rainbow
{
    public static class Rainbow
    {
        public static void RainbowEffect()
        {
            try {
                bool flag = Rainbow.runlock == 1;
                if (flag)
                {
                    bool flag2 = Rainbow.A != 75;
                    if (flag2)
                    {
                        Rainbow.A--;
                    }
                    bool flag3 = Rainbow.G == 130;
                    if (flag3)
                    {
                        bool flag4 = Rainbow.A == 75;
                        if (flag4)
                        {
                            Rainbow.runlock++;
                        }
                        else
                        {
                            Rainbow.A--;
                        }
                    }
                    else
                    {
                        Rainbow.G--;
                    }
                }
                bool flag5 = Rainbow.runlock == 2;
                if (flag5)
                {
                    bool flag6 = Rainbow.G == 254;
                    if (flag6)
                    {
                        bool flag7 = Rainbow.A == 0;
                        if (flag7)
                        {
                            Rainbow.runlock++;
                        }
                        else
                        {
                            Rainbow.A--;
                        }
                    }
                    else
                    {
                        Rainbow.G++;
                    }
                }
                bool flag8 = Rainbow.runlock == 3;
                if (flag8)
                {
                    bool flag9 = Rainbow.R == 254;
                    if (flag9)
                    {
                        bool flag10 = Rainbow.G == 1;
                        if (flag10)
                        {
                            Rainbow.runlock++;
                        }
                        else
                        {
                            Rainbow.G--;
                        }
                    }
                    else
                    {
                        Rainbow.R++;
                    }
                }
                bool flag11 = Rainbow.runlock == 4;
                if (flag11)
                {
                    bool flag12 = Rainbow.A == 254;
                    if (flag12)
                    {
                        bool flag13 = Rainbow.R == 254;
                        if (flag13)
                        {
                            Rainbow.runlock++;
                        }
                        else
                        {
                            Rainbow.R = 254;
                        }
                    }
                    else
                    {
                        Rainbow.A++;
                    }
                }
                bool flag14 = Rainbow.runlock == 5;
                if (flag14)
                {
                    bool flag15 = Rainbow.A == 254;
                    if (flag15)
                    {
                        bool flag16 = Rainbow.R == 127;
                        if (flag16)
                        {
                            Rainbow.runlock++;
                        }
                        else
                        {
                            Rainbow.R--;
                        }
                    }
                    else
                    {
                        Rainbow.A = 254;
                    }
                }
                bool flag17 = Rainbow.runlock == 6;
                if (flag17)
                {
                    bool flag18 = Rainbow.R == 1;
                    if (flag18)
                    {
                        bool flag19 = Rainbow.A == 254;
                        if (flag19)
                        {
                            Rainbow.runlock++;
                        }
                        else
                        {
                            Rainbow.A = 254;
                        }
                    }
                    else
                    {
                        Rainbow.R--;
                    }
                }
                bool flag20 = Rainbow.runlock == 7;
                if (flag20)
                {
                    bool flag21 = Rainbow.A == 148;
                    if (flag21)
                    {
                        bool flag22 = Rainbow.G == 211;
                        if (flag22)
                        {
                            Rainbow.A = 148;
                            Rainbow.R = 0;
                            Rainbow.G = 211;
                            Rainbow.runlock = 1;
                        }
                        else
                        {
                            Rainbow.G++;
                        }
                    }
                    else
                    {
                        Rainbow.A--;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("RaidAPI.dll might be missing. If not send the below exception to me.\r\n" + (ex.Message), "ItroublveTSC");
            }
        }

        public static int A = 148;

        public static int R = 0;

        public static int G = 211;

        public static int runlock = 1;
    }
}
