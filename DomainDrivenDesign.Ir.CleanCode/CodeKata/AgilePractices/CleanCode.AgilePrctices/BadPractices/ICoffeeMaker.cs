namespace CleanCode.AgilePractices.BadPractices
{
    public enum WarmerPlateStatus
    {
        WarmerEmpty,
        PotEmpty,
        PotNotEmpty
    }

    public enum BoilerStatus
    {
        Empty,
        NotEmpty
    }

    public enum BrewButtonStatus
    {
        Pushed,
        Not_Pushed
    }

    public enum BoilerState
    {
        On,
        Off
    }

    public enum WarmerState
    {
        On,
        Off
    }

    public enum IndicateState
    {
        On,Off
    }

    public enum ReliedValueState
    {
        On,Off
    }


    /// <summary>
    /// The heating element for the boiler. It can be turned on or off.
    /// The heating element for the warmer plate. It can be turned on or off.
    /// The sensor for the warmer plate. It has three status: warmerEmpty, potEmpty, potNotEmpty.
    /// A sensor for the warmer plate, which determines whether water is present. It has two status:
    ///  boilerEmpty or boilerNotEmpty.
    /// 
    /// The Brew Button. This momentary button starts the brewing cycle. It has an indicator that
    /// lights up when the brewing cycle is over and the coffee is ready.
    ///
    /// 
    /// A pressure-relief valve that opens to reduce the pressure in the boiler. The drop in pressure
    /// stops thw flow of water to the boiler. The value can be opened or closed.
    /// </summary>
    public interface ICoffeeMaker
    {
        /// <summary>
        /// This function returns the status of the warmer-plate sensor. This sensor
        /// detects the presence of the pot and whether it has coffee in it.
        /// </summary>
        /// <returns></returns>
        WarmerPlateStatus GetWarmerPlateStatus();
        /// <summary>
        /// This function returns the status of the boiler switch. The boiler switch
        /// is a float switch that detects if there is more than 1/2 cup of water in the boiler.
        /// </summary>
        /// <returns></returns>
        BoilerStatus GetBoilerStatus();
        /// <summary>
        /// This function returns the status of the new button.
        /// The brew button is a momentary switch that remembers its state.
        /// Each call to this function returns the remembered state and the resets that
        /// state to NotPushed.
        ///
        /// Thus, even if this function is polled at a very slow rate, it will still detects
        /// the brew button is pushed.
        /// </summary>
        /// <returns></returns>
        BrewButtonStatus GetBrewButtonStatus();
        /// <summary>
        /// This function turns the heating element in the boiler on or off.
        /// </summary>
        /// <param name="state"></param>
        void SetBoilerState(BoilerState state);
        /// <summary>
        /// This function turns the heating element in the warmer plate on or off.
        /// </summary>
        /// <param name="state"></param>
        void SetWarmerState(WarmerState state);
        /// <summary>
        /// This function turns the indicator light on or off.
        /// The indicator light should be turned on at the end of
        /// the brewing cycle. It should be tuned off when the user presses the brew button.
        /// </summary>
        /// <param name="state"></param>
        void SetIndicatorState(IndicateState state);
        /// <summary>
        /// This function opens and closes the pressure-relief value.
        /// When this value is closed, steam pressure in the boiler will force hot water
        /// to spray out over the coffee filter.
        /// When the value is open, the steam in the boiler escapes into the environment,
        /// and the water in the boiler will not spray out over the filter.
        /// </summary>
        /// <param name="reliedValueState"></param>
        void SetReliefValveState(ReliedValueState reliedValueState);
    }

}