using Newtonsoft.Json;
public class LineGraphDTO
{
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public List<object> data;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string xkey;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public List<string> ykeys;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public List<string> labels;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string element;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string preUnits;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string postUnits;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public List<string> goals;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public List<string> events;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public int? goalStrokeWidth;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public int? eventStrokeWidth;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public List<string> lineColors;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public int? lineWidth;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public int? pointSize;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public List<string> pointFillColors;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public List<string> pointStrokeColors;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string ymax;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string ymin;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public bool? smooth;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string hideHover;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public bool? parseTime;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string xLabels;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public List<string> goalLineColors;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public List<string> eventLineColors;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public bool? continuousLine;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public bool? axes;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public bool? grid;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string gridTextColor;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public int? gridTextSize;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string gridTextFamily;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public string gridTextWeight;
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public double? fillOpacity;
    public string ToJSON()
    {
        return JsonConvert.SerializeObject(this);
    }
    //functions:
    //  hoverCallback: function (index, options, content) {}
    //  dateFormat: function (x) {}
    //  xLabelFormat: function (x) { }
    //  yLabelFormat: function (x) { }
}