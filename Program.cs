using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

internal class Program
{
    
    private static void Main(string[] args)
    {
        
        while(true)
        {

        string[,] Win =
        {
            {"       ||     ||                 __________           ||    ||     OO                   "},
            {"       ||     ||    ||     ||    |  ____  |           ||    ||           |+____         "},
            {"        L_   _J     ||     ||    |  |  |  |           ||    ||     ||    ||   ||        "},
            {"          |||       ||     ||    |  |__|  |           || || ||     ||    ||   ||        "},
            {"          |||        L_____J     |________|            L_JL_J      ||    ||   ||        "},
            {"                                    You win!                                            "}
        };

        string[,] Lol =
        {
            {"               T        T             OLOO.LLL.OLOO,OLOO.LLL.OLOO,OLOO.LLL.OLOO,OLOO.LLL.OLOO,                                                            "},
            {"               |        |             OLOO.LLL.OLOO,OLOO.LLL.OLOO,OLOO.LLL.OLOO,OLOO.LLL.OLOO,                                "},
            {"               |        |             OLOO.LLL.OLOO,OLOO.LLL.OLOO,OLOO.LLL.OLOO,OLOO.LLL.OLOO,                                "},
            {"               |        |             OLOO.LLL.OLOO,OLOO.LLL.OLOO,OLOO.LLL.OLOO,OLOO.LLL.OLOO,                                "},
            {"               #        #             OLOO.LLL.OLOO,OLOO.LLL.OLOO,OLOO.LLL.OLOO,OLOO.LLL.OLOO,                                "},
            {"           L                J         OLOO.LLL.OLOO,OLOO.LLL.OLOO,OLOO.LLL.OLOO,OLOO.LLL.OLOO,                                "},
            {"            L______________J          OLOO.LLL.OLOO,OLOO.LLL.OLOO,OLOO.LLL.OLOO,OLOO.LLL.OLOO,                                                            "},
        };

        string[,] Start =
        {
            {"                ______                ______                       "},
            {"                ||   ||      OO       ||   ||                      "},
            {"                ||___J                ||___J                       "},
            {"                ||LJ         ||       ||                           "},
            {"                ||  LJ       ||       ||                           "},
            {"                                                                   "},
            {"                Нажмите 'Enter' чтобы начать                       "}
        };

        char[,] map =
        {
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',},
            {'#','#','M','#','V',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',},
            {'#',' ',' ','#','#','#','#','#',' ',' ',' ','#','#',' ','#','#',},
            {'#',' ','#','#',' ',' ',' ','#',' ','#','#','#',' ',' ','#','#',},
            {'#',' ',' ',' ',' ','#',' ','#',' ','#',' ',' ',' ','#',' ','#',},
            {'#',' ','#','#',' ','#',' ','#',' ','#',' ','#','#','#',' ','#',},
            {'#',' ',' ','#',' ','#',' ',' ',' ','#','#','#',' ','#',' ','#',},
            {'#','#',' ',' ',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ','#',},
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',}
        };

        char[,] map1 =
        {
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','Z','O','V'},
            {'#','#','#','#','V',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','Z','O','V'},
            {'#',' ',' ','#','#','#','#','#','#','#','#','#','#',' ','#',' ',' ',' ','#',' ',' ',' ','#',' ',' ','#',' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' ','#','#',' ','#','Z','O','V'},
            {'#',' ','#',' ',' ',' ','#',' ',' ',' ','#','#',' ',' ','#','#','#','#','#',' ','#','#','#','#',' ',' ',' ','M',' ','#','#','L','O','L','#',' ','#',' ','#',' ','#',' ','#','#',' ','#','Z','O','V'},
            {'#',' ','#',' ','#',' ','#',' ','#',' ',' ','#',' ','#','#','#','#',' ','#',' ','#',' ',' ',' ','#',' ','#','#',' ',' ',' ','#','#','#',' ',' ','#',' ','#',' ',' ',' ','#','#',' ','#','Z','O','V'},
            {'#',' ','#',' ','#',' ','#',' ',' ','#',' ','#',' ','#','#',' ','#',' ',' ',' ','#',' ','#',' ','#',' ',' ','#',' ','#',' ','#',' ',' ',' ','#','#',' ','#','#',' ','#',' ','#',' ','#','Z','O','V'},
            {'#',' ','#',' ','#',' ',' ','#',' ','#',' ','#',' ','#','#',' ','#',' ','#','#','#',' ','#',' ',' ','#',' ','#',' ','#',' ',' ',' ','#',' ','#','#',' ','#',' ',' ','#',' ','#',' ','#','Z','O','V'},
            {'#',' ','#',' ',' ','#',' ','#',' ','#',' ','#',' ','#','#',' ','#',' ','#',' ','#',' ','#','#','#',' ',' ','#',' ','#','#','#',' ',' ','#',' ',' ',' ','#',' ','#',' ',' ','#',' ','#','Z','O','V'},
            {'#',' ','#','#',' ','#',' ','#',' ','#',' ','#',' ','#','#',' ','#',' ',' ',' ','#',' ','#',' ',' ','#','#','#',' ',' ',' ',' ','#','#',' ',' ','#','#','#',' ','#',' ','#','#',' ','#','Z','O','V'},
            {'#',' ',' ','#',' ','#',' ','#',' ','#',' ','#',' ','#','#',' ','#','#','#','#','#',' ',' ',' ','#',' ',' ',' ','#',' ','#',' ','#',' ',' ','#',' ',' ','#','#','#',' ','#','#',' ','#','Z','O','V'},
            {'#','#',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ','#',' ','/',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','Z','O','V'},
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','Z','O','V'}
        };

        int UserX = 2, UserY = 2;
        char Move, Skin, Z, Died;
        string Mod, X;


        Skin = '@';
        X = "A";
        Z = ' ';

        for (int i = 0; i < Start.GetLength(0); i++)
        {
            for (int j = 0; j < Start.GetLength(1); j++)
            {
                Console.Write(Start[i, j]);
            }
            Console.WriteLine();
        }

        Console.ReadLine();

        while (true)
        {

            Move = ' ';

            map[UserY, UserX] = Skin;

            if (map[1, 4] != 'V')
            {
                map[4, 15] = '[';
            }

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }

            while (Move == ' ')
            {
                Mod = Console.ReadLine();

                if (Mod == "wasdssawd" && Z != '1')
                {

                    map[UserY, UserX] = ' ';

                    UserY = 4;
                    UserX = 14;


                    map[UserY, UserX] = Skin;

                    for (int i = 0; i < map.GetLength(0); i++)
                    {
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            Console.Write(map[i, j]);
                        }
                        Console.WriteLine();
                    }

                    map[4, 15] = '[';

                    break;

                }
                else
                if (Mod == "LOL")
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("LOLOLOLOLOLOLOLOLOLOLOLOLOLOLLOLOLOLOL Нету ручек - нет конфетки ;) LOLOLOLOLOLOLOLOLOLOLOLOLOLOLLOLOLOLOLOL");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    for (int i = 0; i < Lol.GetLength(0); i++)
                    {
                        for (int j = 0; j < Lol.GetLength(1); j++)
                        {
                            Console.Write(Lol[i, j]);
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Skin = '$';
                    UserY = 2;
                    UserX = 2;
                    map = map1;
                    Z = '1';
                    Win = Lol;
                    break;
                }
                else
                if (Mod == "Skin" && Z != '1')
                {
                    Skin = ' ';
                    break;
                }
                else
                if (Mod == "Skin1" && Z != '1')
                {
                    Skin = '@';
                    break;
                }
                else
                if (Mod == "Skin2" && Z != '1')
                {
                    Skin = '&';
                    break;
                }
                else
                if (Mod == "Skin3" && Z != '1')
                {
                    Skin = '_';
                    break;
                }
                if (Mod == "Skin4" && Z != '1')
                {
                    Skin = 'h';
                    break;
                }
                else
                {
                    if (Mod.Length == X.Length)
                    { Move = Convert.ToChar(Mod); }
                    else
                    {
                        Console.WriteLine("Управление на 'w', 'a', 's', 'd' ");

                        for (int i = 0; i < map.GetLength(0); i++)
                        {
                            for (int j = 0; j < map.GetLength(1); j++)
                            {
                                Console.Write(map[i, j]);
                            }
                            Console.WriteLine();
                        }

                    }
                }
            }

            switch (Move)
            {
                case 'w':
                    if (map[UserY - 1, UserX] != '#' && map[UserY - 1, UserX] != 'M')
                    {
                        UserY -= 1;
                        map[UserY + 1, UserX] = ' ';
                    }
                    break;

                case 'W':
                    if (map[UserY - 1, UserX] != '#')
                    {
                        UserY -= 1;
                        map[UserY + 1, UserX] = ' ';
                    }
                    break;

                case 'i':
                    if (map[UserY - 2, UserX] != '#')
                    {
                        UserY -= 2;
                        map[UserY + 2, UserX] = ' ';
                    }
                    break;

                case 'I':
                    if (map[UserY - 2, UserX] != '#')
                    {
                        UserY -= 2;
                        map[UserY + 2, UserX] = ' ';
                    }
                    break;
                    
                case 's':
                    if (map[UserY + 1, UserX] != '#')
                    {
                        UserY += 1;
                        map[UserY - 1, UserX] = ' ';
                    }
                    break;

                case 'S':
                    if (map[UserY + 1, UserX] != '#')
                    {
                        UserY += 1;
                        map[UserY - 1, UserX] = ' ';
                    }
                    break;

                case 'a':
                    if (map[UserY, UserX - 1] != '#')
                    {
                        UserX -= 1;
                        map[UserY, UserX + 1] = ' ';
                    }
                    break;

                case 'A':
                    if (map[UserY, UserX - 1] != '#')
                    {
                        UserX -= 1;
                        map[UserY, UserX + 1] = ' ';
                    }
                    break;

                case 'd':
                    if (map[UserY, UserX + 1] != '#')
                    {
                        UserX += 1;
                        map[UserY, UserX - 1] = ' ';
                    }
                    break;

                case 'D':
                    if (map[UserY, UserX + 1] != '#')
                    {
                        UserX += 1;
                        map[UserY, UserX - 1] = ' ';
                    }
                    break;

                case 'r':
                    map[UserY, UserX] = ' ';
                    UserY = 2;
                    UserX = 2;
                    break;

                case 'R':
                    map[UserY, UserX] = ' ';
                    UserY = 2;
                    UserX = 2;
                    break;

                case ' ':
                    break;

                default:
                    Console.WriteLine("Управление 'w','a','s','d' ");
                    break;
            }

            if (map[4, 15] == map[UserY, UserX])
            {
                break;
            }

        }

        for (int i = 0; i < Win.GetLength(0); i++)
        {
            for (int j = 0; j < Win.GetLength(1); j++)
            {
                Console.Write(Win[i, j]);
            }
            Console.WriteLine();
        }

        Console.ReadLine();

        }
    
    }
}