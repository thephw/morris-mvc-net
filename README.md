Description
==
This is planned to be a library to wrap the functionality on morris.js for asp.net mvc 5

Use in Controller
==
```
LineGraphDTO model = new LineGraphDTO() {
    data = foo.Select(a => new { value = a.Value, date = a.bar.ToString("yyyy-MM-dd") }).ToList<object>(),
    element = "chart",
    labels = new List<string> { "Value" },
    xkey = "date",
    ykeys = new List<string> {"value"},
};
```

Use in View
==
```
<script>
  new Morris.Line(@Html.Raw(Model.ToJSON()));
</script>
```