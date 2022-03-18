int[] n = { 5, 4, 3, 2, 1 };
            int temp = 0; 

            for (int write = 0; write < n.Length; write++)
            { // quante volte l'array va controllato

                for (int sort = 0; sort < n.Length - 1; sort++)
                { // controllo di tutto l'array 1 volta

                    if (n[sort] > n[sort + 1])
                    {
                        temp = n[sort + 1];
                        n[sort + 1] = n[sort];
                        n[sort] = temp;
                    }

                }

            }

            label1.Text = "";

            for (int i = 0; i < n.Length; i++)
            { // visualizzazione 

                label1.Text += (n[i] + " ");
            }