namespace Engine.Mediators
{
    public enum EInitializePriority
    {
        /// <summary>
        /// Приоритет высокого уровня. Инициализация выполняется первой.
        /// </summary>
        High,

        /// <summary>
        /// Приоритет среднего уровня. Инициализация выполняется второй.
        /// </summary>
        Medium,

        /// <summary>
        /// Приоритет низкого уровня. Инициализация выполняется последней.
        /// </summary>
        Low,
    }
}