﻿using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TestStack.BDDfy
{
    public interface IInitialStep<TScenario>
    {
        IGiven<TScenario> Given(Expression<Action<TScenario>> givenStep, bool includeInputsInStepTitle);
        IWhen<TScenario> When(Expression<Action<TScenario>> whenStep, bool includeInputsInStepTitle);

        IGiven<TScenario> Given(Expression<Action<TScenario>> givenStep, string stepTextTemplate = null);
        IWhen<TScenario> When(Expression<Action<TScenario>> whenStep, string stepTextTemplate = null);

        IGiven<TScenario> Given(Expression<Func<TScenario, Task>> givenStep, string stepTextTemplate = null);
        IWhen<TScenario> When(Expression<Func<TScenario, Task>> whenStep, string stepTextTemplate = null);
        IGiven<TScenario> Given(Expression<Func<TScenario, Task>> givenStep, bool includeInputsInStepTitle);
        IWhen<TScenario> When(Expression<Func<TScenario, Task>> whenStep, bool includeInputsInStepTitle);
    }
}