// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace TetrisDB {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class GUISystemHandInvisibleGreenEventHandler {
        
        public GreenLightComponent Group;
        
        private TetrisDB.HandInvisibleEvent _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private UnityEngine.GameObject ActionNode178_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode178_state = default( System.Boolean );
        
        private bool BoolNode179 = false;
        
        public TetrisDB.HandInvisibleEvent Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode178_obj = Group.gameObject;
            ActionNode178_state = BoolNode179;
            // ActionNode
            while (this.DebugInfo("afbc5001-5e11-44c9-bc89-603a26360905","e0a55816-3c04-4cb8-9bd7-bf22eecabf3f", this) == 1) yield return null;
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode178_obj, ActionNode178_state);
            yield break;
        }
    }
}
