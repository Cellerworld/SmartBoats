using System.IO;
public class DataCollector
{
    private string data = "";

    public DataCollector()
    {

    }

    public void addData(float pMin, float pMax, float pMid)
    {
        data += pMin + ", " + pMax + ", " + pMid + "\n";
    }

    public void writeFile(string pPath)
    {
        using (StreamWriter writer = new StreamWriter(pPath))
        {
            writer.WriteLine(data);
        }
    }

}