using System;
using System.Collections.Generic;
using System.Text;


    public  class  Figure
    {
        //this is the list with all figures
        public IList<char[,]> listOfFigures { get; set; }
        public char[,] figure1 { get; set; }
        //constructor
        public Figure()
        {
        }
        public void MakeAllFigures()
        {
            figure1 = new char[1,4];
            listOfFigures = new List<char[,]>();
            //****
            for (int i = 0; i < 4; i++)
            {
                this.figure1[0,i] = '*';
            }
            listOfFigures.Add(figure1);
            //**
            //**
            figure1 = new char[2, 2];
            figure1[0, 0] = '*';
            figure1[0, 1] = '*';
            figure1[1, 0] = '*';
            figure1[1, 1] = '*';
            listOfFigures.Add(figure1);
            for (int i = 0; i < listOfFigures.Count; i++)
            {
                for (int j = 0; j < listOfFigures[i].GetLength(0); j++)
                {
                    for (int c = 0; c < listOfFigures[i].GetLength(1); c++)
                    {
                        Console.WriteLine(listOfFigures[i][j,c]);
                    }
                }
            }
            listOfFigures.Add(figure1);
        }
        
         
      
    }

