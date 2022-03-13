     //You call this method with RandomNames, it returns string output
    
     Random Names = new Random();
     String GetName = RandomNames();
     private string RandomNames()
        {
        
        //normal random function to get random integer
        Random Names = new Random();
        
        //we make array with random "part" names from where we pick 2-4 random "parts"      
            string[] Parts = new string[]{
              "na", "eu", "no", "ga", "habe", "naur", "es", "au", "bo", "ra", "aabe", "gaur", "ue", "la", "ve", "va", "avu", "nes",
                "cee", "jar", "hur", "mer", "sa", "de", "ba", "eha", "mold"
            };

        //Empty/Create the string which holds the randomized name
            String NameRandom = "";
            int NameLength = Names.Next(2, 4);

        //Loop through the randomized name length and get "parts" for constructing the randomized name
            for(int i = 0; i < NameLength; i++)
            {
                int b = Names.Next(1, Parts.Count());
                NameRandom = NameRandom + Parts[b];
            }

            //returns firstletter as Upper
            return char.ToUpper(NameRandom[0]) + NameRandom.Substring(1);
        }
