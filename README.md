# t4sample

## Summary

In this sample I use a simple T4 template to generate Java code.

It's very simple just to demonstrate the basics.

## T4

The t4 template is in `_gen/GenJava.tt`.

```t4
<#
  // How many print statements to generate
  var number = 10;
#>
public class GenJava {
    public static void Print() {
<# for (var i = 0; i < number; ++i) { #>
        System.out.println("<#=i#>");
<# } #>
    }
}
```

This just loops a number of times and generates a number of print statements like so:

```java
public class GenJava {
    public static void Print() {
        System.out.println("0");
        System.out.println("1");
        System.out.println("2");
        System.out.println("3");
        System.out.println("4");
        System.out.println("5");
        System.out.println("6");
        System.out.println("7");
        System.out.println("8");
        System.out.println("9");
    }
}
```

### Running the t4 template

```bash
# Install the dotnet tools
dotnet tool install
# Run the t4 template
dotnet t4 -o javaapp/src/main/java/GenJava.java _gen/GenJava.tt
```

## Java

Run the java app:
```bash
# Goto the java app
cd javaapp
# Run it using gradle
gradle run
```

## Generate the t4 file using cake

Run cake build:
```bash
# Install the dotnet tools
dotnet tool install
# Run cake
dotnet cake
```
