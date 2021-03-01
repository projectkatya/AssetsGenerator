using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AssetsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputFile = "d:/projectkatya/assets/utilities.css";
            List<string> breakpoints = new List<string>() { "", "sm", "md", "lg", "xl", "xxl" };
            Dictionary<string, int> minWidths = new Dictionary<string, int>() { { "sm", 576 }, { "md", 768 }, { "lg", 992 }, { "xl", 1200 }, { "xxl", 1400 } };

            // padding
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (string breakpoint in breakpoints)
                {
                    if (!string.IsNullOrEmpty(breakpoint))
                    {
                        stringBuilder.AppendLine($"@media (min-width:{minWidths[breakpoint]}px) {{");
                    }

                    for (double i = 0; i < 13; i++)
                    {
                        if (string.IsNullOrEmpty(breakpoint))
                        {
                            stringBuilder.AppendLine(string.Join('-', ".pad", i) + $" {{ padding:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".pad-x", i) + $" {{ padding-left:{i * 0.25}rem !important; padding-right:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".pad-y", i) + $" {{ padding-top:{i * 0.25}rem !important; padding-bottom:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".pad-t", i) + $" {{ padding-top:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".pad-r", i) + $" {{ padding-right:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".pad-b", i) + $" {{ padding-bottom:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".pad-l", i) + $" {{ padding-left:{i * 0.25}rem !important; }}");
                        }
                        else
                        {
                            stringBuilder.AppendLine(string.Join('-', ".pad", breakpoint, i) + $" {{ padding:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".pad-x", breakpoint, i) + $" {{ padding-left:{i * 0.25}rem !important; padding-right:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".pad-y", breakpoint, i) + $" {{ padding-top:{i * 0.25}rem !important; padding-bottom:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".pad-t", breakpoint, i) + $" {{ padding-top:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".pad-r", breakpoint, i) + $" {{ padding-right:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".pad-b", breakpoint, i) + $" {{ padding-bottom:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".pad-l", breakpoint, i) + $" {{ padding-left:{i * 0.25}rem !important; }}");
                        }
                    }
                    if (!string.IsNullOrEmpty(breakpoint))
                    {
                        stringBuilder.AppendLine("}");
                    }
                }
                writer.WriteLine(stringBuilder);
            }



            //margin
            using (StreamWriter writer = new StreamWriter(outputFile, true))
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($".margin-x-auto {{ margin-left:auto; margin-right:auto; }}");
                foreach (string breakpoint in breakpoints)
                {
                    if (!string.IsNullOrEmpty(breakpoint))
                    {
                        stringBuilder.AppendLine($"@media (min-width:{minWidths[breakpoint]}px) {{");
                    }

                    for (double i = 0; i < 13; i++)
                    {
                        if (string.IsNullOrEmpty(breakpoint))
                        {
                            stringBuilder.AppendLine(string.Join('-', ".margin", i) + $" {{ margin:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".margin-x", i) + $" {{ margin-left:{i * 0.25}rem !important; margin-right:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".margin-y", i) + $" {{ margin-top:{i * 0.25}rem !important; margin-bottom:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".margin-t", i) + $" {{ margin-top:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".margin-r", i) + $" {{ margin-right:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".margin-b", i) + $" {{ margin-bottom:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".margin-l", i) + $" {{ margin-left:{i * 0.25}rem !important; }}");
                        }
                        else
                        {
                            stringBuilder.AppendLine(string.Join('-', ".margin", breakpoint, i) + $" {{ margin:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".margin-x", breakpoint, i) + $" {{ margin-left:{i * 0.25}rem !important; margin-right:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".margin-y", breakpoint, i) + $" {{ margin-top:{i * 0.25}rem !important; margin-bottom:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".margin-t", breakpoint, i) + $" {{ margin-top:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".margin-r", breakpoint, i) + $" {{ margin-right:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".margin-b", breakpoint, i) + $" {{ margin-bottom:{i * 0.25}rem !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".margin-l", breakpoint, i) + $" {{ margin-left:{i * 0.25}rem !important; }}");
                        }
                    }
                    if (!string.IsNullOrEmpty(breakpoint))
                    {
                        stringBuilder.AppendLine("}");
                    }
                }
                writer.WriteLine(stringBuilder);
            }

            //border
            using (StreamWriter writer = new StreamWriter(outputFile, true))
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (string breakpoint in breakpoints)
                {
                    if (!string.IsNullOrEmpty(breakpoint))
                    {
                        stringBuilder.AppendLine($"@media (min-width:{minWidths[breakpoint]}px) {{");
                    }

                    for (double i = 0; i < 2; i++)
                    {
                        string borderAppearance = "";
                        if (i > 0)
                        {
                            borderAppearance = "solid #dee2e6";
                        }
                        if (string.IsNullOrEmpty(breakpoint))
                        {
                            stringBuilder.AppendLine(string.Join('-', ".border", i) + $" {{ border: {i}px {borderAppearance} !important }}");
                            stringBuilder.AppendLine(string.Join('-', ".border-x", i) + $" {{ border-left: {i}px {borderAppearance} !important; border-right: {i}px {borderAppearance} !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".border-y", i) + $" {{ border-top: {i}px {borderAppearance} !important; border-bottom: {i}px {borderAppearance} !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".border-t", i) + $" {{ border-top: {i}px {borderAppearance} !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".border-r", i) + $" {{ border-right: {i}px {borderAppearance} !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".border-b", i) + $" {{ border-bottom: {i}px {borderAppearance} !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".border-l", i) + $" {{ border-left: {i}px {borderAppearance} !important; }}");
                        }
                        else
                        {
                            stringBuilder.AppendLine(string.Join('-', ".border", breakpoint, i) + $" {{ border: {i}px {borderAppearance} !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".border-x", breakpoint, i) + $" {{ border-left: {i}px {borderAppearance} !important; border-right: {i}px {borderAppearance} !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".border-y", breakpoint, i) + $" {{ border-top: {i}px {borderAppearance} !important; border-bottom: {i}px {borderAppearance} !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".border-t", breakpoint, i) + $" {{ border-top: {i}px {borderAppearance} !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".border-r", breakpoint, i) + $" {{ border-right: {i}px {borderAppearance} !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".border-b", breakpoint, i) + $" {{ border-bottom: {i}px {borderAppearance} !important; }}");
                            stringBuilder.AppendLine(string.Join('-', ".border-l", breakpoint, i) + $" {{ border-left: {i}px {borderAppearance} !important; }}");
                        }
                    }
                    if (!string.IsNullOrEmpty(breakpoint))
                    {
                        stringBuilder.AppendLine("}");
                    }
                }
                writer.WriteLine(stringBuilder);
            }

            using (StreamWriter writer = new StreamWriter(outputFile, true))
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 12; i < 31; i++)
                {
                    stringBuilder.AppendLine($".text-{i}px {{font-size: {i}px !important; }}");
                }
                writer.WriteLine(stringBuilder);
            }

            using (StreamWriter writer = new StreamWriter(outputFile, true))
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 10; i <= 1300; i += 10)
                {
                    stringBuilder.AppendLine($".wrapper-{i / 10} {{ width:100%; max-width: {i}px !important; }}");
                }
                writer.WriteLine(stringBuilder);
            }

            using (StreamWriter writer = new StreamWriter(outputFile, true))
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 10; i <= 1300; i += 10)
                {
                    stringBuilder.AppendLine($".hard-wrapper-{i / 10} {{ width: {i}px !important; min-width: {i}px !important; }}");
                }
                writer.WriteLine(stringBuilder);
            }

            // individual classes
            using (StreamWriter writer = new StreamWriter(outputFile, true))
            {
                writer.WriteLine(".square { position:relative; width:100%; padding-bottom:100%; overflow:hidden; }");
                writer.WriteLine(".widescreen { position:relative; width:100%; padding-bottom:56.25%; overflow:hidden; }");
                writer.WriteLine(".widescreen *, .square * { position:absolute; height:100%; width:100%;  overflow:hidden; }");
                writer.WriteLine(".col-bottom-fix { margin-bottom: 30px; }");
                writer.WriteLine(".link-black { color: rgba(0,0,0,1); }");
                writer.WriteLine(".link-black:hover { color: rgba(0,0,0,0.5); text-decoration:none; }");
                writer.WriteLine(".text-bold { font-weight: bold; }");
                writer.WriteLine(".text-decoration-none:hover, .text-decoration-none a:hover { text-decoration:none; }");
                writer.WriteLine(".input-group-bordered { border: 1px solid #ced4da; border-radius: 0.25rem; }");
                writer.WriteLine(".border-control { border-color: #ced4da!important; }");
                writer.WriteLine(".text-black { color: rgba(0,0,0,1); }");
                writer.WriteLine(".ion-label { display:flex; align-items:center; }");
            }

            using (StreamWriter writer = new StreamWriter(outputFile, true))
            {
                for (int i = 0; i < 31; i++)
                {
                    writer.WriteLine($".border-radius-{i} {{ border-radius: {i}px; }}");
                    writer.WriteLine($".border-radius-t-{i} {{ border-top-left-radius: {i}px; border-top-right-radius: {i}px; }}");
                    writer.WriteLine($".border-radius-r-{i} {{ border-top-right-radius: {i}px; border-bottom-right-radius: {i}px; }}");
                    writer.WriteLine($".border-radius-b-{i} {{ border-bottom-left-radius: {i}px; border-bottom-right-radius: {i}px; }}");
                    writer.WriteLine($".border-radius-l-{i} {{ border-top-left-radius: {i}px; border-bottom-left-radius: {i}px; }}");
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFile, true))
            {
                for (int i = 1000; i < 2000; i++)
                {
                    writer.WriteLine($".z-index-{i} {{ z-index: {i}; }}");
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFile, true))
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (string breakpoint in breakpoints)
                {
                    if (!string.IsNullOrEmpty(breakpoint))
                    {
                        stringBuilder.AppendLine($"@media (min-width:{minWidths[breakpoint]}px) {{");
                    }

                    for (double i = 0; i < 2; i++)
                    {
                        string gutterMargin = "margin-left: 0; margin-right: 0;";
                        string colPadding = "padding-left:0; padding-right:0;";
                        if (i > 0)
                        {
                            gutterMargin = "margin-left: -15px; margin-right: -15px;";
                            colPadding = "padding-left:15px; padding-right:15px;";
                        }
                        if (string.IsNullOrEmpty(breakpoint))
                        {
                            string className = $".gutters-{i}";
                            stringBuilder.AppendLine(className + $" {{ {gutterMargin} }}");
                            className = $".gutters-{i} > .col, .gutters-{i} > [class*=\"col-\"] ";
                            stringBuilder.AppendLine(className + $" {{ {colPadding} }}");
                        }
                        else
                        {
                            string className = $".gutters-{breakpoint}-{i}";
                            stringBuilder.AppendLine(className + $" {{ {gutterMargin} }}");
                            className = $".gutters-{breakpoint}-{i} > .col, .gutters-{breakpoint}-{i} > [class*=\"col-\"] ";
                            stringBuilder.AppendLine(className + $" {{ {colPadding} }}");
                        }
                    }
                    if (!string.IsNullOrEmpty(breakpoint))
                    {
                        stringBuilder.AppendLine("}");
                    }
                }
                writer.WriteLine(stringBuilder);
            }
        }
    }
}
