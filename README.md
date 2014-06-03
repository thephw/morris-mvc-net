Description
==
This is planned to be a library to wrap the functionality on morris.js for asp.net mvc 5

Use in Controller
==
```
public ActionResult AssessmentOverTime(List<Foo> foos)
{
  LineGraphDTO model = new LineGraphDTO() {
      data = foos.Select(foo => new { value = foo.Value, date = foo.date.ToString("yyyy-MM-dd") }).ToList<object>(),
      element = "chart",
      labels = new List<string> { "Value" },
      xkey = "date",
      ykeys = new List<string> {"value"},
  };
  return View(model);
}
```

Use in View
==
```
<script>
  new Morris.Line(@Html.Raw(Model.ToJSON()));
</script>
```

Dependencies
===
Currently dependent on http://james.newtonking.com/json