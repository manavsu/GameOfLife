// Created on 2023-09-23 by Manavjot Singh
// (c) Amber Kinetics 2023

namespace GameOfLife;

public class UniversalRules {
    public Func<int, bool> PersistenceRule { get; }
    public Func<int, bool> EmergenceRule { get; }
    public bool WrapEdges { get; }

    public UniversalRules() : this((n) => n is 2 or 3, (n) => n == 3, true) { }
    
    public UniversalRules(Func<int, bool> persistenceRule, Func<int, bool> emergenceRule, bool wrapEdges) {
        PersistenceRule = persistenceRule;
        EmergenceRule = emergenceRule;
        WrapEdges = wrapEdges;
    }
}