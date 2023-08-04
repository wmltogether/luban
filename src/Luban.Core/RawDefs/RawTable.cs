using Luban.Defs;

namespace Luban.RawDefs;

public class RawTable
{
    public string Namespace { get; set; }

    public string Name { get; set; }

    public string Index { get; set; }

    public string ValueType { get; set; }

    public bool ReadSchemaFromFile { get; set; }

    public TableMode Mode { get; set; }

    public string Comment { get; set; }

    public string Tags { get; set; }

    public List<string> Groups { get; set; } = new List<string>();

    public List<string> InputFiles { get; set; } = new List<string>();

    public string OutputFile { get; set; }
}