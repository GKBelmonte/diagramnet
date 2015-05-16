using System;
using System.Drawing;

namespace Dalssoft.DiagramNet
{
	/// <summary>
	/// To a class be a controller, it need to implements this interface.
	/// </summary>
	public interface IController
	{
		BaseElement OwnerElement {get;}

		bool HitTest(Point p);
	
		bool HitTest(Rectangle r);

		void DrawSelection(Graphics g);
	}
}
