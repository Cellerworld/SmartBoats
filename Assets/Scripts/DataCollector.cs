using System.IO;
public class DataCollector
{
    private string data;

    public void addData(float pMin, float pMax, float pMid)
    {

    }

    public void writeFile(string pPath)
    {
        using (StreamWriter writer = new StreamWriter(pPath))
        {
            data = "1, 2, 3\n4, 5, 6";
            writer.WriteLine(data);
        }
    }

}