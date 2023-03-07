//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from GoHorse.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="GoHorseParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public interface IGoHorseVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] GoHorseParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStat([NotNull] GoHorseParser.StatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.readln"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReadln([NotNull] GoHorseParser.ReadlnContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.writeln"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWriteln([NotNull] GoHorseParser.WritelnContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.ifStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStat([NotNull] GoHorseParser.IfStatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.whileStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStat([NotNull] GoHorseParser.WhileStatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.untilStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUntilStat([NotNull] GoHorseParser.UntilStatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.forStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStat([NotNull] GoHorseParser.ForStatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.assign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssign([NotNull] GoHorseParser.AssignContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.varDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDecl([NotNull] GoHorseParser.VarDeclContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] GoHorseParser.AssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.refeExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRefeExpr([NotNull] GoHorseParser.RefeExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunc([NotNull] GoHorseParser.FuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParams([NotNull] GoHorseParser.ParamsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParam([NotNull] GoHorseParser.ParamContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.orExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrExpr([NotNull] GoHorseParser.OrExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.andExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAndExpr([NotNull] GoHorseParser.AndExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.equalExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEqualExpr([NotNull] GoHorseParser.EqualExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.relatExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelatExpr([NotNull] GoHorseParser.RelatExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.addExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddExpr([NotNull] GoHorseParser.AddExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.multExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultExpr([NotNull] GoHorseParser.MultExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.unary_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnary_expr([NotNull] GoHorseParser.Unary_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.primary_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimary_expr([NotNull] GoHorseParser.Primary_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] GoHorseParser.ExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTerm([NotNull] GoHorseParser.TermContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactor([NotNull] GoHorseParser.FactorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="GoHorseParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] GoHorseParser.TypeContext context);
}
