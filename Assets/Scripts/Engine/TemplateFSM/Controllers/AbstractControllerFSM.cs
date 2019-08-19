using System;
using System.Collections.Generic;
using UnityEngine;

namespace Engine.TemplateFSM
{
    public abstract class AbstractControllerFsm<TStateType> : IControllerFsm<TStateType>
    {
        public event Action<TStateType, TStateType> OnChangeState;

        protected Dictionary<TStateType, IStateFsm<TStateType>> _stateCollections;
        protected TStateType _currentStateType;

        public TStateType CurrentState => _currentStateType;

        protected AbstractControllerFsm ()
        {
            _stateCollections = new Dictionary<TStateType, IStateFsm<TStateType>> ();
        }

        protected void AddState (TStateType stateType, IStateFsm<TStateType> state)
        {
            _stateCollections.Add (stateType, state);
        }

        public void Start (TStateType stateType)
        {
            _currentStateType = stateType;
            _stateCollections[_currentStateType].OnEnter (default);
        }

        public void Switch (TStateType stateType)
        {
            Debug.Log ($"Change state FSM '{_currentStateType}' --> '{stateType}'");

            _stateCollections[_currentStateType].OnExit (stateType);
            _stateCollections[stateType].OnEnter (_currentStateType);
            _currentStateType = stateType;
        }
    }
}