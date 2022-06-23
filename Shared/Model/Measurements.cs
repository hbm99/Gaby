using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Gaby.Shared.Interfaces;
using Gaby.Shared.Utils;

namespace Gaby.Shared.Model
{
    /// <summary>
    /// Body measurements.
    /// </summary>
    public class Measurements : IMeasurements
    {
        [Key]
        public int MeasurementsId { get; set; }

        public MemberClient MemberClient { get; set; }

        /// <summary>
        /// Returns measurements date.
        /// </summary>
        public BasicDate MeasurementsDate { get; set; }

        /// <summary>
        /// Returns client height.
        /// </summary>
        public float Height { get; set; }

        /// <summary>
        /// Returns right arm measurement.
        /// </summary>
        public float ArmSize { get; set; }

        /// <summary>
        /// Returns right thigh measurement.
        /// </summary>
        public float ThighSize { get; set; }

        /// <summary>
        /// Returns chest measurement.
        /// </summary>
        public float ChestSize { get; set; }

        /// <summary>
        /// Returns right calf measurement.
        /// </summary>
        public float CalfSize { get; set; }

        /// <summary>
        /// Returns hip measurement.
        /// </summary>
        public float HipSize { get; set; }

        /// <summary>
        /// Returns waist measurement.
        /// </summary>
        public float WaistSize { get; set; }

        /// <summary>
        /// Returns client weight.
        /// </summary>
        public float Weight { get; set; }
    }
}

