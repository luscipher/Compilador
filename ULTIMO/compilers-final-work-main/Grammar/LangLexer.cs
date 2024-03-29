//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Lang.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Grammar {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class LangLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, OE=5, CE=6, OB=7, CB=8, AT=9, SEP=10, 
		PLUS=11, MINUS=12, MULT=13, DIV=14, AND=15, OR=16, NOT=17, EQ=18, LT=19, 
		GT=20, LE=21, GE=22, NE=23, BOOL_TRUE=24, BOL_FALSE=25, IF=26, WHILE=27, 
		DO=28, FOR=29, FUNCTION=30, RETURN=31, THEN=32, ELSE=33, WRITE=34, READ=35, 
		STR=36, EOL=37, NUM=38, VAR=39, COMMENT=40, WS=41;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "OE", "CE", "OB", "CB", "AT", "SEP", "PLUS", 
		"MINUS", "MULT", "DIV", "AND", "OR", "NOT", "EQ", "LT", "GT", "LE", "GE", 
		"NE", "BOOL_TRUE", "BOL_FALSE", "IF", "WHILE", "DO", "FOR", "FUNCTION", 
		"RETURN", "THEN", "ELSE", "WRITE", "READ", "STR", "EOL", "NUM", "VAR", 
		"COMMENT", "WS"
	};


	public LangLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public LangLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'int'", "'string'", "'float'", "'bool'", "'('", "')'", "'{'", "'}'", 
		"'='", "','", "'+'", "'-'", "'*'", "'/'", "'&&'", "'||'", "'!'", "'=='", 
		"'<'", "'>'", "'<='", "'>='", "'!='", "'true'", "'false'", null, null, 
		null, null, null, null, null, null, null, null, null, "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, "OE", "CE", "OB", "CB", "AT", "SEP", "PLUS", 
		"MINUS", "MULT", "DIV", "AND", "OR", "NOT", "EQ", "LT", "GT", "LE", "GE", 
		"NE", "BOOL_TRUE", "BOL_FALSE", "IF", "WHILE", "DO", "FOR", "FUNCTION", 
		"RETURN", "THEN", "ELSE", "WRITE", "READ", "STR", "EOL", "NUM", "VAR", 
		"COMMENT", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Lang.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static LangLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '+', '\x108', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x4', '*', '\t', '*', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', 
		'\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', 
		'\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', 
		'\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', 
		'\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', 
		'\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', 
		'\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x3', 
		'\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', 
		'\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', 
		'\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', '\x3', 
		'\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', 
		'\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', ' ', 
		'\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x3', '!', '\x3', '!', '\x3', '\"', '\x3', '\"', '\x3', '\"', 
		'\x3', '\"', '\x3', '\"', '\x3', '#', '\x3', '#', '\x3', '#', '\x3', '#', 
		'\x3', '#', '\x3', '#', '\x3', '$', '\x3', '$', '\x3', '$', '\x3', '$', 
		'\x3', '$', '\x3', '%', '\x3', '%', '\a', '%', '\xDA', '\n', '%', '\f', 
		'%', '\xE', '%', '\xDD', '\v', '%', '\x3', '%', '\x3', '%', '\x3', '&', 
		'\x3', '&', '\x3', '\'', '\x6', '\'', '\xE4', '\n', '\'', '\r', '\'', 
		'\xE', '\'', '\xE5', '\x3', '\'', '\x3', '\'', '\x6', '\'', '\xEA', '\n', 
		'\'', '\r', '\'', '\xE', '\'', '\xEB', '\x5', '\'', '\xEE', '\n', '\'', 
		'\x3', '(', '\x3', '(', '\a', '(', '\xF2', '\n', '(', '\f', '(', '\xE', 
		'(', '\xF5', '\v', '(', '\x3', ')', '\x3', ')', '\x3', ')', '\x3', ')', 
		'\a', ')', '\xFB', '\n', ')', '\f', ')', '\xE', ')', '\xFE', '\v', ')', 
		'\x3', ')', '\x3', ')', '\x3', '*', '\x6', '*', '\x103', '\n', '*', '\r', 
		'*', '\xE', '*', '\x104', '\x3', '*', '\x3', '*', '\x2', '\x2', '+', '\x3', 
		'\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', 
		'\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', 
		'\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', 
		'\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', 
		'/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', 
		'\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x43', 
		'#', '\x45', '$', 'G', '%', 'I', '&', 'K', '\'', 'M', '(', 'O', ')', 'Q', 
		'*', 'S', '+', '\x3', '\x2', '\x17', '\x4', '\x2', 'K', 'K', 'k', 'k', 
		'\x4', '\x2', 'H', 'H', 'h', 'h', '\x4', '\x2', 'Y', 'Y', 'y', 'y', '\x4', 
		'\x2', 'J', 'J', 'j', 'j', '\x4', '\x2', 'N', 'N', 'n', 'n', '\x4', '\x2', 
		'G', 'G', 'g', 'g', '\x4', '\x2', '\x46', '\x46', '\x66', '\x66', '\x4', 
		'\x2', 'Q', 'Q', 'q', 'q', '\x4', '\x2', 'T', 'T', 't', 't', '\x4', '\x2', 
		'W', 'W', 'w', 'w', '\x4', '\x2', 'P', 'P', 'p', 'p', '\x4', '\x2', '\x45', 
		'\x45', '\x65', '\x65', '\x4', '\x2', 'V', 'V', 'v', 'v', '\x4', '\x2', 
		'U', 'U', 'u', 'u', '\x4', '\x2', '\x43', '\x43', '\x63', '\x63', '\x3', 
		'\x2', '$', '$', '\x3', '\x2', '\x32', ';', '\x5', '\x2', '\x43', '\\', 
		'\x61', '\x61', '\x63', '|', '\x6', '\x2', '\x32', ';', '\x43', '\\', 
		'\x61', '\x61', '\x63', '|', '\x4', '\x2', '\f', '\f', '\xF', '\xF', '\x5', 
		'\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\x10E', '\x2', '\x3', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x31', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', '\x37', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', '\x2', '\x2', 
		';', '\x3', '\x2', '\x2', '\x2', '\x2', '=', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '?', '\x3', '\x2', '\x2', '\x2', '\x2', '\x41', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x43', '\x3', '\x2', '\x2', '\x2', '\x2', '\x45', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'G', '\x3', '\x2', '\x2', '\x2', '\x2', 'I', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'K', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'M', '\x3', '\x2', '\x2', '\x2', '\x2', 'O', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'Q', '\x3', '\x2', '\x2', '\x2', '\x2', 'S', '\x3', '\x2', '\x2', 
		'\x2', '\x3', 'U', '\x3', '\x2', '\x2', '\x2', '\x5', 'Y', '\x3', '\x2', 
		'\x2', '\x2', '\a', '`', '\x3', '\x2', '\x2', '\x2', '\t', '\x66', '\x3', 
		'\x2', '\x2', '\x2', '\v', 'k', '\x3', '\x2', '\x2', '\x2', '\r', 'm', 
		'\x3', '\x2', '\x2', '\x2', '\xF', 'o', '\x3', '\x2', '\x2', '\x2', '\x11', 
		'q', '\x3', '\x2', '\x2', '\x2', '\x13', 's', '\x3', '\x2', '\x2', '\x2', 
		'\x15', 'u', '\x3', '\x2', '\x2', '\x2', '\x17', 'w', '\x3', '\x2', '\x2', 
		'\x2', '\x19', 'y', '\x3', '\x2', '\x2', '\x2', '\x1B', '{', '\x3', '\x2', 
		'\x2', '\x2', '\x1D', '}', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x7F', 
		'\x3', '\x2', '\x2', '\x2', '!', '\x82', '\x3', '\x2', '\x2', '\x2', '#', 
		'\x85', '\x3', '\x2', '\x2', '\x2', '%', '\x87', '\x3', '\x2', '\x2', 
		'\x2', '\'', '\x8A', '\x3', '\x2', '\x2', '\x2', ')', '\x8C', '\x3', '\x2', 
		'\x2', '\x2', '+', '\x8E', '\x3', '\x2', '\x2', '\x2', '-', '\x91', '\x3', 
		'\x2', '\x2', '\x2', '/', '\x94', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\x97', '\x3', '\x2', '\x2', '\x2', '\x33', '\x9C', '\x3', '\x2', '\x2', 
		'\x2', '\x35', '\xA2', '\x3', '\x2', '\x2', '\x2', '\x37', '\xA5', '\x3', 
		'\x2', '\x2', '\x2', '\x39', '\xAB', '\x3', '\x2', '\x2', '\x2', ';', 
		'\xAE', '\x3', '\x2', '\x2', '\x2', '=', '\xB2', '\x3', '\x2', '\x2', 
		'\x2', '?', '\xBB', '\x3', '\x2', '\x2', '\x2', '\x41', '\xC2', '\x3', 
		'\x2', '\x2', '\x2', '\x43', '\xC7', '\x3', '\x2', '\x2', '\x2', '\x45', 
		'\xCC', '\x3', '\x2', '\x2', '\x2', 'G', '\xD2', '\x3', '\x2', '\x2', 
		'\x2', 'I', '\xD7', '\x3', '\x2', '\x2', '\x2', 'K', '\xE0', '\x3', '\x2', 
		'\x2', '\x2', 'M', '\xE3', '\x3', '\x2', '\x2', '\x2', 'O', '\xEF', '\x3', 
		'\x2', '\x2', '\x2', 'Q', '\xF6', '\x3', '\x2', '\x2', '\x2', 'S', '\x102', 
		'\x3', '\x2', '\x2', '\x2', 'U', 'V', '\a', 'k', '\x2', '\x2', 'V', 'W', 
		'\a', 'p', '\x2', '\x2', 'W', 'X', '\a', 'v', '\x2', '\x2', 'X', '\x4', 
		'\x3', '\x2', '\x2', '\x2', 'Y', 'Z', '\a', 'u', '\x2', '\x2', 'Z', '[', 
		'\a', 'v', '\x2', '\x2', '[', '\\', '\a', 't', '\x2', '\x2', '\\', ']', 
		'\a', 'k', '\x2', '\x2', ']', '^', '\a', 'p', '\x2', '\x2', '^', '_', 
		'\a', 'i', '\x2', '\x2', '_', '\x6', '\x3', '\x2', '\x2', '\x2', '`', 
		'\x61', '\a', 'h', '\x2', '\x2', '\x61', '\x62', '\a', 'n', '\x2', '\x2', 
		'\x62', '\x63', '\a', 'q', '\x2', '\x2', '\x63', '\x64', '\a', '\x63', 
		'\x2', '\x2', '\x64', '\x65', '\a', 'v', '\x2', '\x2', '\x65', '\b', '\x3', 
		'\x2', '\x2', '\x2', '\x66', 'g', '\a', '\x64', '\x2', '\x2', 'g', 'h', 
		'\a', 'q', '\x2', '\x2', 'h', 'i', '\a', 'q', '\x2', '\x2', 'i', 'j', 
		'\a', 'n', '\x2', '\x2', 'j', '\n', '\x3', '\x2', '\x2', '\x2', 'k', 'l', 
		'\a', '*', '\x2', '\x2', 'l', '\f', '\x3', '\x2', '\x2', '\x2', 'm', 'n', 
		'\a', '+', '\x2', '\x2', 'n', '\xE', '\x3', '\x2', '\x2', '\x2', 'o', 
		'p', '\a', '}', '\x2', '\x2', 'p', '\x10', '\x3', '\x2', '\x2', '\x2', 
		'q', 'r', '\a', '\x7F', '\x2', '\x2', 'r', '\x12', '\x3', '\x2', '\x2', 
		'\x2', 's', 't', '\a', '?', '\x2', '\x2', 't', '\x14', '\x3', '\x2', '\x2', 
		'\x2', 'u', 'v', '\a', '.', '\x2', '\x2', 'v', '\x16', '\x3', '\x2', '\x2', 
		'\x2', 'w', 'x', '\a', '-', '\x2', '\x2', 'x', '\x18', '\x3', '\x2', '\x2', 
		'\x2', 'y', 'z', '\a', '/', '\x2', '\x2', 'z', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', '{', '|', '\a', ',', '\x2', '\x2', '|', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', '}', '~', '\a', '\x31', '\x2', '\x2', '~', '\x1E', '\x3', '\x2', 
		'\x2', '\x2', '\x7F', '\x80', '\a', '(', '\x2', '\x2', '\x80', '\x81', 
		'\a', '(', '\x2', '\x2', '\x81', ' ', '\x3', '\x2', '\x2', '\x2', '\x82', 
		'\x83', '\a', '~', '\x2', '\x2', '\x83', '\x84', '\a', '~', '\x2', '\x2', 
		'\x84', '\"', '\x3', '\x2', '\x2', '\x2', '\x85', '\x86', '\a', '#', '\x2', 
		'\x2', '\x86', '$', '\x3', '\x2', '\x2', '\x2', '\x87', '\x88', '\a', 
		'?', '\x2', '\x2', '\x88', '\x89', '\a', '?', '\x2', '\x2', '\x89', '&', 
		'\x3', '\x2', '\x2', '\x2', '\x8A', '\x8B', '\a', '>', '\x2', '\x2', '\x8B', 
		'(', '\x3', '\x2', '\x2', '\x2', '\x8C', '\x8D', '\a', '@', '\x2', '\x2', 
		'\x8D', '*', '\x3', '\x2', '\x2', '\x2', '\x8E', '\x8F', '\a', '>', '\x2', 
		'\x2', '\x8F', '\x90', '\a', '?', '\x2', '\x2', '\x90', ',', '\x3', '\x2', 
		'\x2', '\x2', '\x91', '\x92', '\a', '@', '\x2', '\x2', '\x92', '\x93', 
		'\a', '?', '\x2', '\x2', '\x93', '.', '\x3', '\x2', '\x2', '\x2', '\x94', 
		'\x95', '\a', '#', '\x2', '\x2', '\x95', '\x96', '\a', '?', '\x2', '\x2', 
		'\x96', '\x30', '\x3', '\x2', '\x2', '\x2', '\x97', '\x98', '\a', 'v', 
		'\x2', '\x2', '\x98', '\x99', '\a', 't', '\x2', '\x2', '\x99', '\x9A', 
		'\a', 'w', '\x2', '\x2', '\x9A', '\x9B', '\a', 'g', '\x2', '\x2', '\x9B', 
		'\x32', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x9D', '\a', 'h', '\x2', 
		'\x2', '\x9D', '\x9E', '\a', '\x63', '\x2', '\x2', '\x9E', '\x9F', '\a', 
		'n', '\x2', '\x2', '\x9F', '\xA0', '\a', 'u', '\x2', '\x2', '\xA0', '\xA1', 
		'\a', 'g', '\x2', '\x2', '\xA1', '\x34', '\x3', '\x2', '\x2', '\x2', '\xA2', 
		'\xA3', '\t', '\x2', '\x2', '\x2', '\xA3', '\xA4', '\t', '\x3', '\x2', 
		'\x2', '\xA4', '\x36', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA6', '\t', 
		'\x4', '\x2', '\x2', '\xA6', '\xA7', '\t', '\x5', '\x2', '\x2', '\xA7', 
		'\xA8', '\t', '\x2', '\x2', '\x2', '\xA8', '\xA9', '\t', '\x6', '\x2', 
		'\x2', '\xA9', '\xAA', '\t', '\a', '\x2', '\x2', '\xAA', '\x38', '\x3', 
		'\x2', '\x2', '\x2', '\xAB', '\xAC', '\t', '\b', '\x2', '\x2', '\xAC', 
		'\xAD', '\t', '\t', '\x2', '\x2', '\xAD', ':', '\x3', '\x2', '\x2', '\x2', 
		'\xAE', '\xAF', '\t', '\x3', '\x2', '\x2', '\xAF', '\xB0', '\t', '\t', 
		'\x2', '\x2', '\xB0', '\xB1', '\t', '\n', '\x2', '\x2', '\xB1', '<', '\x3', 
		'\x2', '\x2', '\x2', '\xB2', '\xB3', '\t', '\x3', '\x2', '\x2', '\xB3', 
		'\xB4', '\t', '\v', '\x2', '\x2', '\xB4', '\xB5', '\t', '\f', '\x2', '\x2', 
		'\xB5', '\xB6', '\t', '\r', '\x2', '\x2', '\xB6', '\xB7', '\t', '\xE', 
		'\x2', '\x2', '\xB7', '\xB8', '\t', '\x2', '\x2', '\x2', '\xB8', '\xB9', 
		'\t', '\t', '\x2', '\x2', '\xB9', '\xBA', '\t', '\f', '\x2', '\x2', '\xBA', 
		'>', '\x3', '\x2', '\x2', '\x2', '\xBB', '\xBC', '\t', '\n', '\x2', '\x2', 
		'\xBC', '\xBD', '\t', '\a', '\x2', '\x2', '\xBD', '\xBE', '\t', '\xE', 
		'\x2', '\x2', '\xBE', '\xBF', '\t', '\v', '\x2', '\x2', '\xBF', '\xC0', 
		'\t', '\n', '\x2', '\x2', '\xC0', '\xC1', '\t', '\f', '\x2', '\x2', '\xC1', 
		'@', '\x3', '\x2', '\x2', '\x2', '\xC2', '\xC3', '\t', '\xE', '\x2', '\x2', 
		'\xC3', '\xC4', '\t', '\x5', '\x2', '\x2', '\xC4', '\xC5', '\t', '\a', 
		'\x2', '\x2', '\xC5', '\xC6', '\t', '\f', '\x2', '\x2', '\xC6', '\x42', 
		'\x3', '\x2', '\x2', '\x2', '\xC7', '\xC8', '\t', '\a', '\x2', '\x2', 
		'\xC8', '\xC9', '\t', '\x6', '\x2', '\x2', '\xC9', '\xCA', '\t', '\xF', 
		'\x2', '\x2', '\xCA', '\xCB', '\t', '\a', '\x2', '\x2', '\xCB', '\x44', 
		'\x3', '\x2', '\x2', '\x2', '\xCC', '\xCD', '\t', '\x4', '\x2', '\x2', 
		'\xCD', '\xCE', '\t', '\n', '\x2', '\x2', '\xCE', '\xCF', '\t', '\x2', 
		'\x2', '\x2', '\xCF', '\xD0', '\t', '\xE', '\x2', '\x2', '\xD0', '\xD1', 
		'\t', '\a', '\x2', '\x2', '\xD1', '\x46', '\x3', '\x2', '\x2', '\x2', 
		'\xD2', '\xD3', '\t', '\n', '\x2', '\x2', '\xD3', '\xD4', '\t', '\a', 
		'\x2', '\x2', '\xD4', '\xD5', '\t', '\x10', '\x2', '\x2', '\xD5', '\xD6', 
		'\t', '\b', '\x2', '\x2', '\xD6', 'H', '\x3', '\x2', '\x2', '\x2', '\xD7', 
		'\xDB', '\a', '$', '\x2', '\x2', '\xD8', '\xDA', '\n', '\x11', '\x2', 
		'\x2', '\xD9', '\xD8', '\x3', '\x2', '\x2', '\x2', '\xDA', '\xDD', '\x3', 
		'\x2', '\x2', '\x2', '\xDB', '\xD9', '\x3', '\x2', '\x2', '\x2', '\xDB', 
		'\xDC', '\x3', '\x2', '\x2', '\x2', '\xDC', '\xDE', '\x3', '\x2', '\x2', 
		'\x2', '\xDD', '\xDB', '\x3', '\x2', '\x2', '\x2', '\xDE', '\xDF', '\a', 
		'$', '\x2', '\x2', '\xDF', 'J', '\x3', '\x2', '\x2', '\x2', '\xE0', '\xE1', 
		'\a', '=', '\x2', '\x2', '\xE1', 'L', '\x3', '\x2', '\x2', '\x2', '\xE2', 
		'\xE4', '\t', '\x12', '\x2', '\x2', '\xE3', '\xE2', '\x3', '\x2', '\x2', 
		'\x2', '\xE4', '\xE5', '\x3', '\x2', '\x2', '\x2', '\xE5', '\xE3', '\x3', 
		'\x2', '\x2', '\x2', '\xE5', '\xE6', '\x3', '\x2', '\x2', '\x2', '\xE6', 
		'\xED', '\x3', '\x2', '\x2', '\x2', '\xE7', '\xE9', '\v', '\x2', '\x2', 
		'\x2', '\xE8', '\xEA', '\t', '\x12', '\x2', '\x2', '\xE9', '\xE8', '\x3', 
		'\x2', '\x2', '\x2', '\xEA', '\xEB', '\x3', '\x2', '\x2', '\x2', '\xEB', 
		'\xE9', '\x3', '\x2', '\x2', '\x2', '\xEB', '\xEC', '\x3', '\x2', '\x2', 
		'\x2', '\xEC', '\xEE', '\x3', '\x2', '\x2', '\x2', '\xED', '\xE7', '\x3', 
		'\x2', '\x2', '\x2', '\xED', '\xEE', '\x3', '\x2', '\x2', '\x2', '\xEE', 
		'N', '\x3', '\x2', '\x2', '\x2', '\xEF', '\xF3', '\t', '\x13', '\x2', 
		'\x2', '\xF0', '\xF2', '\t', '\x14', '\x2', '\x2', '\xF1', '\xF0', '\x3', 
		'\x2', '\x2', '\x2', '\xF2', '\xF5', '\x3', '\x2', '\x2', '\x2', '\xF3', 
		'\xF1', '\x3', '\x2', '\x2', '\x2', '\xF3', '\xF4', '\x3', '\x2', '\x2', 
		'\x2', '\xF4', 'P', '\x3', '\x2', '\x2', '\x2', '\xF5', '\xF3', '\x3', 
		'\x2', '\x2', '\x2', '\xF6', '\xF7', '\a', '\x31', '\x2', '\x2', '\xF7', 
		'\xF8', '\a', '\x31', '\x2', '\x2', '\xF8', '\xFC', '\x3', '\x2', '\x2', 
		'\x2', '\xF9', '\xFB', '\n', '\x15', '\x2', '\x2', '\xFA', '\xF9', '\x3', 
		'\x2', '\x2', '\x2', '\xFB', '\xFE', '\x3', '\x2', '\x2', '\x2', '\xFC', 
		'\xFA', '\x3', '\x2', '\x2', '\x2', '\xFC', '\xFD', '\x3', '\x2', '\x2', 
		'\x2', '\xFD', '\xFF', '\x3', '\x2', '\x2', '\x2', '\xFE', '\xFC', '\x3', 
		'\x2', '\x2', '\x2', '\xFF', '\x100', '\b', ')', '\x2', '\x2', '\x100', 
		'R', '\x3', '\x2', '\x2', '\x2', '\x101', '\x103', '\t', '\x16', '\x2', 
		'\x2', '\x102', '\x101', '\x3', '\x2', '\x2', '\x2', '\x103', '\x104', 
		'\x3', '\x2', '\x2', '\x2', '\x104', '\x102', '\x3', '\x2', '\x2', '\x2', 
		'\x104', '\x105', '\x3', '\x2', '\x2', '\x2', '\x105', '\x106', '\x3', 
		'\x2', '\x2', '\x2', '\x106', '\x107', '\b', '*', '\x2', '\x2', '\x107', 
		'T', '\x3', '\x2', '\x2', '\x2', '\n', '\x2', '\xDB', '\xE5', '\xEB', 
		'\xED', '\xF3', '\xFC', '\x104', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Grammar
