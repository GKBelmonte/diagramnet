using System;

namespace Dalssoft.DiagramNet
{
    public abstract class ElementCollectionEventArgs : EventArgs
    { 
    	protected ElementCollection elements;

        public ElementCollectionEventArgs(ElementCollection elements)
		{
			this.elements = elements;
		}

		public ElementCollection Elements
		{
			get{ return elements; }
		}
    }

    public class ElementSelectionEventArgs : ElementCollectionEventArgs 
	{
        public ElementSelectionEventArgs(ElementCollection elements) : base(elements) { }
 
        public override string ToString()
		{
			return "ElementSelection: " + elements.Count.ToString();
		}
	}

    public class ElementDeletedEventArgs : ElementCollectionEventArgs
    {
        public ElementDeletedEventArgs(ElementCollection elements) : base(elements) { }

        public override string ToString()
		{
			return "ElementDeletion: " + elements.Count.ToString();
		}
    }


}
