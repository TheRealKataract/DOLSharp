﻿/*
 * DAWN OF LIGHT - The first free open source DAoC server emulator
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 *
 */
/*
 * [Ganrod] Nidel 2008-07-08
 * - Class for turret, like 1.90 EU official servers: Turret isn't interrupted
 */

namespace DOL.GS
{
  public class TurretPet : GamePet
  {
    public TurretPet(INpcTemplate template)
      : base(template)
    {
    }

  	private Spell turretSpell;

  	/// <summary>
    /// Get first spell only
    /// </summary>
    public Spell TurretSpell
  	{
  		get { return turretSpell; }
  		set { turretSpell = value; }
  	}

  	/// <summary>
    /// [Ganrod] Nidel: Don't interrupt turret cast.
    /// </summary>
    /// <param name="duration"></param>
    /// <param name="attackType"></param>
    /// <param name="attacker"></param>
    public override void StartInterruptTimer(int duration, AttackData.eAttackType attackType, GameLiving attacker)
    {
      return;
    }
  }
}