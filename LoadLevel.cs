// Copyright (c) 2015 Bartlomiej Wolk (bartlomiejwolk@gmail.com)
//  
// This file is part of the LoadLevel extension for Unity.
// Licensed under the MIT license. See LICENSE file in the project root folder.

using UnityEngine;

namespace LoadLevelEx {

    public sealed class LoadLevel : MonoBehaviour {

        #region CONSTANTS

        public const string Version = "v0.1.0";
        public const string Extension = "LoadLevel";

        #endregion

        #region DELEGATES
        #endregion

        #region EVENTS
        #endregion

        #region FIELDS

#pragma warning disable 0414
        /// <summary>
        ///     Allows identify component in the scene file when reading it with
        ///     text editor.
        /// </summary>
        [SerializeField]
        private string componentName = "LoadLevel";
#pragma warning restore0414

        #endregion

        #region INSPECTOR FIELDS

        [SerializeField]
        private string description = "Description";

        #endregion

        #region PROPERTIES

        /// <summary>
        ///     Optional text to describe purpose of this instance of the component.
        /// </summary>
        public string Description {
            get { return description; }
            set { description = value; }
        }

        #endregion

        #region UNITY MESSAGES

        private void Awake() { }

        private void FixedUpdate() { }

        private void LateUpdate() { }

        private void OnEnable() { }

        private void Reset() { }

        private void Start() { }
        private void Update() {
            if (Input.GetKeyDown(KeyCode.R)) {
                Reload();
            }
        }

        private void OnValidate() { }

        private void OnCollisionEnter(Collision collision) { }

        private void OnCollisionStay(Collision collision) { }

        private void OnCollisionExit(Collision collision) { }

        #endregion

        #region EVENT INVOCATORS
        #endregion

        #region EVENT HANDLERS
        #endregion
            #region METHODS
        private void Reload() {
            Application.LoadLevel(Application.loadedLevel);
        }

            #endregion

    }

}