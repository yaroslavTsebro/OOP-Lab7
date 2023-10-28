using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lw1.model
{
    public class Door
    {
        private int height;
        private string doorSign = "Default door sign";
        private bool isOpened;
        private int amountOfWindows;
        private DoorMaterial material;
        private DoorType type;

        // 1. (better to use atomic long or int)
        private static int objectCount = 0;
        private static string doorDescription = "Default door description";

        public static string DoorDescription
        {
            get { return doorDescription; }
            set { doorDescription = value; }
        }
        public static int ObjectCount
        {
            get { return objectCount; }
        }

        private void InitializeDefaultValues()
        {
            height = 150;
            isOpened = false;
            amountOfWindows = 1;
            material = DoorMaterial.IRON;
            type = DoorType.INTERIOR;
        }

        public Door()
        {
            objectCount++;
            InitializeDefaultValues();
        }

        public Door(int height, DoorMaterial material)
        {
            objectCount++;
            InitializeDefaultValues();
            Height = height;
            Material = material;
        }

        public Door(string doorSign, DoorType type)
        {
            InitializeDefaultValues();
            DoorSign = doorSign;
            Type = type;
        }

        public Door(int height, DoorMaterial material, string doorSign, DoorType type)
            : this(height, material)
        {
            DoorSign = doorSign;
            Type = type;
        }

        public static bool HeightRestrictions(int value) => value > 0 && value < 200;
        public static bool AmountOfWindowsRestrictions(int value) => value > 0 && value < 5;
        public static bool DoorSignRestrictions(string value) => value.Trim().Length > 0 && value.Trim().Length < 50;

        public DoorMaterial Material
        {
            get { return material; }
            set { material = value; }
        }

        public DoorType Type
        {
            get { return type; }
            set { type = value; }
        }

        public bool IsOpened
        {
            get { return isOpened; }
            set { isOpened = value; }
        }

        public int AmountOfWindows
        {
            get { return amountOfWindows; }
            set
            {
                if (AmountOfWindowsRestrictions(value))
                    amountOfWindows = value;
                else
                    Console.WriteLine("Недійсна кількість вікон дверей.");
            }
        }

        public string DoorSign
        {
            get { return doorSign; }
            set
            {
                if (DoorSignRestrictions(value))
                    doorSign = value;
                else
                    Console.WriteLine("Недійсний підпис дверей.");
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (HeightRestrictions(value))
                    height = value;
                else
                    Console.WriteLine("Недійсна висота дверей.");
            }
        }

        public string GetDoorInfo()
        {
            return $"Door Sign: {DoorSign}\nHeight: {Height} cm\n" +
                $"Material: {Material}\nType: {Type}\nIs Opened: {IsOpened}\n" +
                $"Windows: {AmountOfWindows}\n" +
                $"Is Solid: {isSolid()}";
        }

        public string GetDoorInfo(DoorInfoType type)
        {
            switch (type)
            {
                case (DoorInfoType.BRIEF):
                    return $"Door Sign: {DoorSign}\nHeight: {Height} cm\nIs Solid: {isSolid()}";

                case (DoorInfoType.STATS):
                    return $"Door Sign: {DoorSign}\nHeight: {Height} cm\nAmount Of Windows: {AmountOfWindows} cm\nIs Opened: {isOpened}";

                case (DoorInfoType.SIGN_ONLY):
                    return $"Door Sign: {DoorSign}";

                case (DoorInfoType.HEIGHT_ONLY):
                    return $"Height: {Height}";

                case (DoorInfoType.WHOLE):
                default:
                    return GetDoorInfo();

            }
        }

        public bool isSolid()
        {
            if(!IsOpened && Material == DoorMaterial.IRON && Type == DoorType.FRONT && AmountOfWindows < 2) return true;
            return false;
        }


        public static Door Parse(string s)
        {
            string[] parts = s.Split(',');
            if (parts.Length != 6)
                throw new FormatException("Invalid input format for parsing.");

            string doorSign = parts[0];
            DoorMaterial material;
            if (!Enum.TryParse(parts[1], out material))
                throw new FormatException("Invalid material value.");

            DoorType type;
            if (!Enum.TryParse(parts[2], out type))
                throw new FormatException("Invalid type value.");

            int height;
            if (!int.TryParse(parts[3], out height) || !HeightRestrictions(height))
                throw new FormatException("Invalid or out-of-range height value.");

            int amountOfWindows;
            if (!int.TryParse(parts[4], out amountOfWindows) || !AmountOfWindowsRestrictions(amountOfWindows))
                throw new FormatException("Invalid or out-of-range amount of windows value.");

            bool isOpened;
            if (!bool.TryParse(parts[5], out isOpened))
                throw new FormatException("Invalid isOpened value.");

            Door door = new Door(height, material, doorSign, type)
            {
                AmountOfWindows = amountOfWindows,
                IsOpened = isOpened
            };

            return door;
        }



        public static bool TryParse(string s, out Door obj)
        {
            obj = null;
            try
            {
                obj = Parse(s); 
                return true;    
            }
            catch (Exception)
            {
                return false;  
            }
        }
        public override string ToString()
        {
            return GetDoorInfo();
        }

        public static void RemoveDoor(List<Door> doors, Door doorToRemove)
        {
            if (doors.Contains(doorToRemove))
            {
                doors.Remove(doorToRemove);
                objectCount--;
                Console.WriteLine($"{doorToRemove.DoorSign} has been removed");
            }
        }
    }
}
