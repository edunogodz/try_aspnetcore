using System;
using System.Collections.Generic;

namespace CharacterSheetApp.Models
{   
    public class Character
    {
        public string Name;

        public static void Create(string characterName)
        {
            var character = new Character();
            character.Name =  characterName;
            if(GlobalVariables.Characters == null)
 GlobalVariables.Characters = new List<Character>();
            GlobalVariables.Characters.Add(character);

        }
        public static List<Character> GetAll()
        {
            if(GlobalVariables.Characters == null)
 GlobalVariables.Characters = new List<Character>();
            return GlobalVariables.Characters;
        }
    }
}