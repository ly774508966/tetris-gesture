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
    
    
    public class GroupSystemGameReadyHandler {
        
        private uFrame.Kernel.GameReadyEvent _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private TetrisDB.GroupMoveEvent PublishEventNode26_Result = default( TetrisDB.GroupMoveEvent );
        
        public uFrame.Kernel.GameReadyEvent Event {
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
            // PublishEventNode
            while (this.DebugInfo("bdfb8aaf-0d1c-4d8a-b0c3-60e35353a182","cd61b2c4-389e-4936-bd8e-cd6af0ea41c0", this) == 1) yield return null;
            var PublishEventNode26_Event = new GroupMoveEvent();
            System.Publish(PublishEventNode26_Event);
            PublishEventNode26_Result = PublishEventNode26_Event;
            yield break;
        }
    }
}
