using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  public class RoomNumber
  {
    private readonly helperMethods _helperMethods = new helperMethods();

    public int numberOfSets(int roomNumber) {

        if (!_helperMethods.InRange(roomNumber)) return 0;
          
            int[] digits = new int[10];
            while (roomNumber != 0)
            {
                digits[roomNumber % 10]++;
                roomNumber /= 10;
            }
            int result = (int)Math.Ceiling((digits[6] + digits[9]) / 2.0);
            for (int i = 0; i < 10; i++)
            {
                if (i == 6 || i == 9)
                {
                    continue;
                }
                result = Math.Max(result, digits[i]);
            }
            return result;
    }
  }

public static class Globals
{
    internal static void Main()
    {
        RoomNumber roomNum = new RoomNumber();

    }
}

