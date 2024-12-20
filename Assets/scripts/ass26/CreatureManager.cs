using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {
        ISwimmable[] swimmables;
        IJumpable[] jumpables;
        IRunnable[] runnables;
        void Start()
        {
            Kangaroo kan1 = new Kangaroo();
            Duck duck1 = new Duck();
            List<Creature> creatures = new List<Creature>();
            creatures.Add(kan1);
            creatures.Add(duck1);
            runnables = new IRunnable[] { kan1, duck1 };
            jumpables = new IJumpable[] { kan1 };
            swimmables = new ISwimmable[] { duck1 };
            foreach (Creature cre in creatures)
            {
                cre.Speak();
            }
            foreach (IRunnable runable in runnables)
            {
                runable.Run();
            }
            foreach (ISwimmable swimmable in swimmables)
            {
                swimmable.Swim();
            }
            foreach (IJumpable jumpable in jumpables)
            {
                jumpable.Jump();
            }
        }
    }
}
