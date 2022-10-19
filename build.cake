var target        = Argument("target", "GenCode");

Task("GenCode")
  .Does(() =>
{
  DotNetTool(".", "t4", "-o javaapp/src/main/java/GenJava.java _gen/GenJava.tt");
});

RunTarget(target);