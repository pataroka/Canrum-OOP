﻿namespace CanrumRPG.Skills.MageSkills
{
    using Characters;

    using Engine;

    using Enums;

    public class Torching : ActiveSkill
    {
        public Torching()
            : base(25, 0, 0, 15, CharClass.Mage, 3)
        {
        }

        protected override void DefaultSkillAction(Character caster, Character target)
        {
            caster.CurrentMana -= this.ManaModifier;
            target.CurrentHealth -= this.AttackModifier;
            GameEngine.Renderer.WriteLine(string.Format("{0} torches {1} for {2} damage.", caster.Name, target.Name, this.AttackModifier));
        }
    }
}
