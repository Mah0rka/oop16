namespace oop16
{
    internal class StringArray
    {
        //автоматичні властивості
        public int lenght { get; set; }
        public string[] Array { get; set; }

        //конструктори
        public StringArray()
        {
            this.lenght = 0;
            this.Array = new string[this.lenght];
        }
        public StringArray(int lenght)
        {
            this.lenght = lenght;
            this.Array = new string[this.lenght];
        }
        public StringArray(int lenght, string[] array)
        {
            this.lenght = lenght;
            this.Array = new string[this.lenght];
            this.Array = array;
        }
        public static StringArray operator +(StringArray Array1, StringArray Array2)//оператор для  зчеплення
        {
            StringArray Array_marge = new(Array1.lenght);
            if (Array1.lenght == Array2.lenght)
            {
                for (int i = 0; i < Array1.lenght; i++)
                {
                    Array_marge.Array[i] = Array1.Array[i] + Array2.Array[i];
                }
            }
            else
            {
                throw new Exception("Array lenght must be same");
            }
            return Array_marge;
        }
        public StringArray MargeAndDelate(StringArray Array1)//функціядля злиття
        {
            StringArray res = new(this.lenght + Array1.lenght);

            for (int i = 0; i < res.lenght; i++)
            {
                if (i < this.lenght)
                    res.Array[i] = this.Array[i];
                else
                {
                    res.Array[i] = Array1.Array[i - this.lenght];
                }
            }
            res.Array = RemoveDuplicates(res.Array);
            return res;
        }
        private static string[] RemoveDuplicates(string[] array)//функція для видалення однакових елементів
        {
            HashSet<string> uniqueStrings = new HashSet<string>();//колекція унікальних елементів

            foreach (string str in array)
            {
                uniqueStrings.Add(str);
            }
            return uniqueStrings.ToArray();
        }
    }
}
