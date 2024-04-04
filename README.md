# Gantt

- no columns on the right side
- separation line for grouping not possible
- no multiple tasks in one record possible

# Calender

- Column Header cannot be above grouping
- Labels on the left side need to be hidden
- no columns on the right side

# Data grid

- table does not allow cells spanning multiple columns
-

# Error

- [Error - 10:35:51 AM] [CLaSP] System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values. (Parameter 'End (46,4) matches or exceeds SourceText boundary 95.')
  at Microsoft.AspNetCore.Razor.LanguageServer.Extensions.SourceTextExtensions.<GetTextSpan>g\__GetAbsoluteIndex|11_0(Int32 line, Int32 character, SourceText sourceText, String argName) in /_/src/Razor/src/Microsoft.AspNetCore.Razor.LanguageServer/Extensions/SourceTextExtensions.cs:line 294
  at Microsoft.AspNetCore.Razor.LanguageServer.Extensions.SourceTextExtensions.GetTextSpan(SourceText sourceText, Int32 startLine, Int32 startCharacter, Int32 endLine, Int32 endCharacter) in /_/src/Razor/src/Microsoft.AspNetCore.Razor.LanguageServer/Extensions/SourceTextExtensions.cs:line 280
  at Microsoft.AspNetCore.Razor.LanguageServer.Extensions.TextEditExtensions.ToTextChange(TextEdit textEdit, SourceText sourceText) in /_/src/Razor/src/Microsoft.AspNetCore.Razor.LanguageServer/Extensions/TextEditExtensions.cs:line 24
  at System.Linq.Enumerable.SelectArrayIterator`2.MoveNext()
 at Microsoft.CodeAnalysis.Text.SourceText.WithChanges(IEnumerable`1 changes)
  at Microsoft.AspNetCore.Razor.LanguageServer.Formatting.HtmlFormattingPass.ExecuteAsync(FormattingContext context, FormattingResult result, CancellationToken cancellationToken) in /_/src/Razor/src/Microsoft.AspNetCore.Razor.LanguageServer/Formatting/HtmlFormattingPass.cs:line 82
  at Microsoft.AspNetCore.Razor.LanguageServer.Formatting.RazorFormattingService.FormatAsync(VersionedDocumentContext documentContext, Range range, FormattingOptions options, CancellationToken cancellationToken) in /_/src/Razor/src/Microsoft.AspNetCore.Razor.LanguageServer/Formatting/RazorFormattingService.cs:line 78
  at Microsoft.AspNetCore.Razor.LanguageServer.Formatting.DocumentFormattingEndpoint.HandleRequestAsync(DocumentFormattingParams request, RazorRequestContext requestContext, CancellationToken cancellationToken) in /\_/src/Razor/src/Microsoft.AspNetCore.Razor.LanguageServer/Formatting/DocumentFormattingEndpoint.cs:line 59
  at Microsoft.CommonLanguageServerProtocol.Framework.QueueItem`3.StartRequestAsync(TRequestContext context, IMethodHandler handler, CancellationToken cancellationToken)
- [Error - 10:35:51 AM] Request textDocument/formatting failed.
  Message: Specified argument was out of the range of valid values. (Parameter 'End (46,4) matches or exceeds SourceText boundary 95.')
  Code: -32004
