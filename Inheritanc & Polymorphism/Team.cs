namespace Inheritance___Polymorphism
{
    internal class Team : Sponsor
    {
        private string teamName;

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="tName"></param>
        public Team(string tName)
        {
            teamName = tName;
        }

        /// <summary>
        /// This Method Returns Concated String Which
        /// includes Owner Name & Team Name
        /// </summary>
        /// <returns>String</returns>
        public string PrintInfo()
        {
            return $"Printing Info : {owner} Sponsors {teamName}";
        }
    }
}
