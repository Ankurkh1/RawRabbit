﻿namespace RawRabbit.Configuration.Queue
{
	public interface IQueueConfigurationBuilder
	{
		IQueueConfigurationBuilder WithName(string queueName);
		IQueueConfigurationBuilder WithNameSuffix(string suffix);
		IQueueConfigurationBuilder WithAutoDelete(bool autoDelete = true);
		IQueueConfigurationBuilder WithDurability(bool durable = true);
		IQueueConfigurationBuilder WithExclusivity(bool exclusive = true);
		IQueueConfigurationBuilder WithArgument(string key, object value);
        IQueueConfigurationBuilder AssumeInitialized(bool asumption = true);
    }
}
