namespace FactoryPatternExercise2
{
    internal class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from a List Database");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List Database");
        }
    }
}