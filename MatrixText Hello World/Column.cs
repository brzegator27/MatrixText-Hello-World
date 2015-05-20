using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Matrix_Hello_World
{
    
    //*************************************************************************************//
    //                                                                                     //
    //  Author:                                                                            //
    //     Name:                  Jakub                                                    //
    //     Surname:          Brzegowski                                                    //
    //     Nick:            brzegator27                                                    //
    //                                                                                     //
    //  Program:                                                                           //
    //     Name: MatrixText Hello World                                                    //
    //     version:                 1.0                                                    //
    //                                                                                     //
    //*************************************************************************************//


    public class Column
    {
        private bool whetherToDisplay = true;

        private Random myRandom = new Random();

        //Do losowania:
        //Zakres zielonych liter na początku:
        private byte minValueOfGreenLetters = 2;
        private byte maxValueOfGreenLetters = 4;

        //Zakres długości kolumny:
        private byte minValueOfColumnLength = 4 + 1;
        private byte maxValueOfColumnLength = 0;

        private short minValueAscii = 33;
        private short maxValueAscii = 126;

        private byte time;                  //s
        private byte timeForLetter;         //ms
        private byte freeTime;              //s
        private short column;
        private short[] positions;
        private string[] letters;
        private byte maxHeight;

        private short presentMaxLength;

        private List<string> columnLetters = new List<string>();
        private List<short> columnLettersLength = new List<short>();
        private List<byte> lenghtOfGreenColor = new List<byte>();
        private List<short> waitingTime = new List<short>();
        private List<bool> canWiew = new List<bool>();
        //private short[] waitingTime = 0;

        private List<short> indexPosition_1 = new List<short>();
        private List<short> indexPosition_2 = new List<short>();
        private List<bool> canNext = new List<bool>();

        //private short indexPosition_1 = 0;
        //private short indexPosition_2 = 0;
        private short indexElement = 0;

        private string stringFromList = "";

        private short numberOfElements = 0;

        public Column(byte time, byte timeForLetter, byte freeTime, short column, string[] letters, short[] positions, byte maxHeight)
        {
            this.time = time;
            this.timeForLetter = timeForLetter;
            this.freeTime = freeTime;
            this.column = column;
            this.positions = positions;
            this.letters = letters;
            this.maxHeight = maxHeight;

            //UWAGA!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //this.waitingTime.Add((short)((freeTime * 1000) / timeForLetter));

            this.presentMaxLength = (short)((time - freeTime) * 1000 / (timeForLetter));

            this.InitializeElements();
        }

        public Column()
        {
            whetherToDisplay = false;
        }

        public void Next()
        {
            if (whetherToDisplay)
            {
                for (int i = 0; i < numberOfElements; i++)
                {
                    if (canWiew[i])///
                    {
                        if (waitingTime[i] > 0) waitingTime[i]--;
                        else
                        {
                            //if (indexPosition_1 + lenghtOfGreenColor[indexElement] < maxHeight)
                            //{
                            //    if (indexPosition_1 < maxHeight)
                            //    {
                            //        columnLetters[indexElement] += RandomGoodLetter(indexPosition_1, (indexElement == (numberOfElements - 1)));

                            //        Console.ForegroundColor = ConsoleColor.Green;
                            //        Console.SetCursorPosition(column, indexPosition_1);
                            //        Console.Write(columnLetters[indexElement]);



                            //        indexPosition_1++;

                            //    }
                            //    else
                            //    {

                            //    }
                            //}
                            //else
                            //{

                            //}

                            if (indexPosition_1[i] < maxHeight)
                            {
                                columnLetters[i] += RandomGoodLetter(indexPosition_1[i], (i == (numberOfElements - 1)));

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(column, indexPosition_1[i]);
                                stringFromList = columnLetters[i];
                                Console.Write(stringFromList[indexPosition_1[i]]);///aaa

                                //indexPosition_1++;
                            }
                            //else indexPosition_1++;

                            if (indexPosition_1[i] - 1 - lenghtOfGreenColor[i] < maxHeight) //if (indexPosition_1[i] - lenghtOfGreenColor[i] <= maxHeight)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;

                                try
                                {
                                    Console.SetCursorPosition(column, (indexPosition_1[i] - 1 - lenghtOfGreenColor[i]));//Console.SetCursorPosition(column, (indexPosition_1[i] - lenghtOfGreenColor[i]));

                                    stringFromList = columnLetters[i];

                                    //UWAGA!!
                                    Console.Write(stringFromList[(indexPosition_1[i] - 1 - lenghtOfGreenColor[i])]);///
                                }
                                catch (ArgumentOutOfRangeException a)
                                {

                                }
                            }
                            //else indexPosition_1 = 0;

                            if (indexPosition_1[i] > columnLettersLength[i])//if ((columnLettersLength[i] - indexPosition_1[i]) <= maxHeight)//if ((columnLettersLength[i] - ++indexPosition_1[i]) <= maxHeight)
                            {
                                if (IsntThereLetter(indexPosition_2[i], (i == (numberOfElements - 1))))//if (IsntThereLetter(indexPosition_2[i], (i == (numberOfElements - 1))))
                                {
                                    Console.SetCursorPosition(column, indexPosition_2[i]);
                                    Console.Write(" ");

                                    if (i < (numberOfElements - 1)) canWiew[(i + 1)] = true;
                                }

                                //if (canNext[i])indexPosition_2[i]++;
                                //canNext[i] = true;

                                indexPosition_2[i]++;
                            }

                            indexPosition_1[i]++;///

                            //if (indexPosition_1[i] == columnLettersLength[i])
                            //{
                            //    //indexElement++;
                            //    indexPosition_1[i] = 0;
                            //    indexPosition_2[i] = 0;
                            //}

                            if (indexPosition_2[i] > maxHeight)
                            {
                                canWiew[i] = false;
                                if (i < (numberOfElements - 1)) canWiew[(i + 1)] = true;///
                            }
                        }

                        //indexElement++;
                    }
                }
            }
        }

        private bool IsntThereLetter(short position, bool isFinal)
        {
            foreach (short positionLetter in this.positions)
            {
                if (position == positionLetter && isFinal) return false;
            }

            return true;
        }

        private string RandomGoodLetter(short position, bool isFinal)
        {
            foreach (short positionLetter in this.positions)
            {
                foreach (string letterOnPosition in this.letters)
                {
                    if (position == positionLetter && isFinal) return letterOnPosition;
                }
            }

            int liczba = 0;
            char litera = ' ';

            liczba = myRandom.Next((int)minValueAscii, (int)maxValueAscii);
            litera = (char)liczba;
            
            return litera.ToString();
        }

        private int RandomColumnTextLength()
        {
            return myRandom.Next(minValueOfColumnLength, presentMaxLength);
        }


        //UWAGA!!!
        private int RandomColumnTextLength(short MaxLength)
        {
            return myRandom.Next(minValueOfColumnLength, MaxLength);
        }

        private int RandomGreenLetterLength(byte min, byte max)
        {
            return myRandom.Next(min, max);
        }

        private int RandomEmptyColumnTextLength(short min, short max)
        {
            //Losuje ile ma być spacji - chodzi o to, aby kolumna tekstu pojawiła się z opóźnieniem
            return myRandom.Next(min, max);
        }

        private void InitializeElements()
        {
            byte i = 0;
            byte a = 6;

            maxValueOfColumnLength = (byte)(presentMaxLength / a);

            while (maxValueOfColumnLength > 1)
            {
                minValueOfGreenLetters = 2;
                maxValueOfGreenLetters = 4;

                minValueOfColumnLength = minValueOfGreenLetters;
                maxValueOfColumnLength = (byte)(presentMaxLength / a);

                columnLettersLength.Add((short)RandomColumnTextLength(maxValueOfColumnLength));

                if (presentMaxLength < 3) waitingTime.Add(0);
                else if (columnLettersLength[i] > 4) waitingTime.Add((short)RandomEmptyColumnTextLength(0, (short)(columnLettersLength[i] - 3)));
                else waitingTime.Add((short)RandomEmptyColumnTextLength(0, (short)(columnLettersLength[i] / 2)));

                columnLettersLength[i] -= waitingTime[i];

                if (columnLettersLength[i] < 3) lenghtOfGreenColor.Add((byte)RandomGreenLetterLength(minValueOfGreenLetters, 2));
                else lenghtOfGreenColor.Add((byte)RandomGreenLetterLength(minValueOfGreenLetters, maxValueOfGreenLetters));

                presentMaxLength -= (short)(columnLettersLength[i] + waitingTime[i]);

                columnLetters.Add("");
                canWiew.Add(false);
                indexPosition_1.Add(0);
                indexPosition_2.Add(0);
                canNext.Add(false);

                i++;
                numberOfElements++;

                if (a > 1) a--;

                maxValueOfColumnLength = (byte)(presentMaxLength / a);
            }

            canWiew[0] = true;
        }
    }
}
