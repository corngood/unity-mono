//
// BaseMetadataVisitor.cs
//
// Author:
//   Jb Evain (jbevain@gmail.com)
//
// Generated by /CodeGen/cecil-gen.rb do not edit
// <%=Time.now%>
//
// (C) 2005 Jb Evain
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace Mono.Cecil.Metadata {

	public abstract class BaseMetadataVisitor : IMetadataVisitor {

		public virtual void VisitMetadataRoot (MetadataRoot root)
		{
		}

		public virtual void VisitMetadataRootHeader (MetadataRoot.MetadataRootHeader header)
		{
		}

		public virtual void VisitMetadataStreamCollection (MetadataStreamCollection streams)
		{
		}

		public virtual void VisitMetadataStream (MetadataStream stream)
		{
		}

		public virtual void VisitMetadataStreamHeader (MetadataStream.MetadataStreamHeader header)
		{
		}

		public virtual void VisitGuidHeap (GuidHeap heap)
		{
		}

		public virtual void VisitStringsHeap (StringsHeap heap)
		{
		}

		public virtual void VisitTablesHeap (TablesHeap heap)
		{
		}

		public virtual void VisitBlobHeap (BlobHeap heap)
		{
		}

		public virtual void VisitUserStringsHeap (UserStringsHeap heap)
		{
		}

		public virtual void TerminateMetadataRoot (MetadataRoot root)
		{
		}
	}

	public abstract class BaseMetadataTableVisitor : IMetadataTableVisitor {

		public virtual void VisitTableCollection (TableCollection coll)
		{
		}

<% $tables.each { |table| %>		public virtual void Visit<%=table.table_name%> (<%=table.table_name%> table)
		{
		}

<% } %>		public virtual void TerminateTableCollection (TableCollection coll)
		{
		}

		public abstract IMetadataRowVisitor GetRowVisitor();
	}

	public abstract class BaseMetadataRowVisitor : IMetadataRowVisitor {

		public virtual void VisitRowCollection (RowCollection coll)
		{
		}

<% $tables.each { |table| %>		public virtual void Visit<%=table.row_name%> (<%=table.row_name%> row)
		{
		}

<% } %>		public virtual void TerminateRowCollection (RowCollection coll)
		{
		}
	}
}
