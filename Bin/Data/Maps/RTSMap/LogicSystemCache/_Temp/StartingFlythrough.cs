using System;
using System.Collections.Generic;
using System.Text;
using Engine;
using Engine.FileSystem;
using Engine.MathEx;
using Engine.Utils;
using Engine.Renderer;
using Engine.PhysicsSystem;
using Engine.SoundSystem;
using Engine.UISystem;
using Engine.EntitySystem;
using Engine.MapSystem;
using ProjectCommon;
using ProjectEntities;

namespace Maps_RTSMap_LogicSystem_LogicSystemScripts
{
	public static class StartingFlythrough
	{
		
		public static void Flythrough()
		{
			Engine.EntitySystem.LogicClass __class = Engine.EntitySystem.LogicSystemManager.Instance.MapClassManager.GetByName( "StartingFlythrough" );
			Engine.EntitySystem.LogicSystem.LogicDesignerMethod __method = (Engine.EntitySystem.LogicSystem.LogicDesignerMethod)__class.GetMethodByName( "Flythrough" );
			__method.Execute( EntitySystemWorld.Instance.GetLogicSystemScriptsAssemblyClassByClassName( "StartingFlythrough" ), new object[ 0 ]{  } );
		}

	}
}
