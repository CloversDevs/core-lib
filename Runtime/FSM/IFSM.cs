using System;

namespace Padoru.Core
{
	public interface IFSM<TState, TTrigger> where TState : Enum where TTrigger : Enum
	{
		void AddTransition(TState initialState, TState targetState, TTrigger trigger);

		void SetTrigger(TTrigger trigger);

		State GetState(TState stateId);
	}
}
