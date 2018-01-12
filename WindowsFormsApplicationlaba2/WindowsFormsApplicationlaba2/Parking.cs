using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationlaba2
{
    class Parking
    {
        List<ClassArray<IAnimal>> parkingStages;

        int countPlaces = 20;

        int placeSizeWidth = 210;

        int placeSizeHeight = 80;

        int currentLevel;

        public int getCurrentLevel { get { return currentLevel; } }

        public Parking(int countStages)
        {
            parkingStages = new List<ClassArray<IAnimal>>(countStages);
            for (int i = 0; i < countStages; i++)
            {
                parkingStages.Add(new ClassArray<IAnimal>(countPlaces, null));
            }
        }

        public void LevelUp()
        {
            if (currentLevel + 1 < parkingStages.Count)
            {
                currentLevel++;
            }
        }

        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }
        }

        public int PutTarantulInShowcase(IAnimal ianimal)
        {
            return parkingStages[currentLevel] + ianimal;
        }

        public IAnimal PutTarantulInShowcase(int ticket)
        {
            return parkingStages[currentLevel] - ticket;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var ianimal = parkingStages[currentLevel][i];
                if (ianimal != null)
                {
                    ianimal.setPosition(5 + i / 5 * placeSizeWidth, i % 5 * placeSizeHeight);
                    ianimal.drawSpiderwolf(g);
                }
            }
        }

        public void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue), (countPlaces / 5) * placeSizeWidth - 70, 420);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
            for (int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
                    if (j < 5)
                    {
                        g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30), new SolidBrush(Color.Blue), i * placeSizeWidth + 30, j * placeSizeHeight + 20);

                    }
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }
        }


    }
}
