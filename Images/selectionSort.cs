int[] array = { 100, 56, 8, 4, 3, 1, 64, 63, 205, 0 };

            int[] selectionSort(int[] arr)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    int lowest = i;
                    int temp = arr[i];
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] < arr[lowest])
                        {
                            lowest = j;
                        }
                    }
                    arr[i] = array[lowest];
                    arr[lowest] = temp;
                }
                return arr;
            }

            label1.Text = "";
            int[] orderedAarray = selectionSort(array);

            for (int i = 0; i < orderedAarray.Length; i++)
            { // visualizzazione 

                label1.Text += (orderedAarray[i] + " ");
            }