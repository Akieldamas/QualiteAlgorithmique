using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Liasse
{
    public IList<Document> documents = new List<Document>();
    public IList<Document> getDocuments()
    {
        return documents;
    }
    protected void setDocuments(Document doc)
    {
        documents.Add(doc);
    }
}
