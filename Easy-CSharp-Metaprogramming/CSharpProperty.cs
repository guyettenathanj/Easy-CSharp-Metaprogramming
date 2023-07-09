﻿using Easy_CSharp_Metaprogramming;

public class CSharpProperty : CSharpCode
{
    public string Type { get; }
    public string Name { get; }
    public AccessModifier AccessModifier { get; }

    public CSharpProperty(string type, string name, string indent,
        AccessModifier accessModifier = AccessModifier.Public) : base(indent)
    {
        Type = type;
        Name = name;
        AccessModifier = accessModifier;
    }


    public override string ReturnCodeString()
    {
        var accessModifierString = AccessModifier.ToString().ToLower();
        Code.Append($"{Indent}{accessModifierString} {Type} {Name} {{ get; set; }}");
        return Code.ToString(); 
    }
}