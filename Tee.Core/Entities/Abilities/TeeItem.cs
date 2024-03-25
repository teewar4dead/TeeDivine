using Divine.Entity.Entities.Abilities.Items;
using Divine.Entity.Entities.Abilities.Items.Components;
using Tee.Core.Entities.Units;
using Tee.Core.Utilities;

namespace Tee.Core.Entities.Abilities
{
    public class TeeItem : TeeAbility
    {
        public Item BaseItem;
        public new TeeUnit Owner => base.Owner as TeeUnit;

        public TeeItem(Item baseEntity) : base(baseEntity)
        {
            BaseItem = baseEntity;
        }
        /// <summary>
        /// Проверяет, достаточно ли маны у владельца предмета для его использования.
        /// </summary>
        public bool IsManaAvailableForCast
        {
            get
            {
                var owner = this.Owner;
                return owner != null && BaseItem.ManaCost <= owner.Mana;
            }
        }

        /// <summary>
        /// Указывает, может ли этот предмет быть объединен с другими для создания нового предмета.
        /// </summary>
        public bool IsCombinable { get { return BaseItem.IsCombinable; } }

        /// <summary>
        /// Указывает, сохранится ли этот предмет в инвентаре после использования.
        /// </summary>
        public bool IsPermanent { get { return BaseItem.IsPermanent; } }

        /// <summary>
        /// Указывает, можно ли складывать несколько таких предметов в одну ячейку инвентаря.
        /// </summary>
        public bool IsStackable { get { return BaseItem.IsStackable; } }

        /// <summary>
        /// Указывает, является ли этот предмет рецептом для создания другого предмета.
        /// </summary>
        public bool IsRecipe { get { return BaseItem.IsRecipe; } }

        /// <summary>
        /// Возвращает информацию о том, можно ли поделиться этим предметом с союзниками.
        /// </summary>
        public Shareability Shareability { get { return BaseItem.Shareability; } }

        /// <summary>
        /// Указывает, можно ли этот предмет выбросить из инвентаря на землю.
        /// </summary>
        public bool IsDroppable { get { return BaseItem.IsDroppable; } }

        /// <summary>
        /// Указывает, доступен ли этот предмет для покупки в магазине.
        /// </summary>
        public bool IsPurchasable { get { return BaseItem.IsPurchasable; } }

        /// <summary>
        /// Указывает, можно ли продать этот предмет в магазине.
        /// </summary>
        public bool IsSellable { get { return BaseItem.IsSellable; } }

        /// <summary>
        /// Указывает, требуется ли для использования этого предмета определенное количество зарядов.
        /// </summary>
        public bool IsRequiringCharges { get { return BaseItem.IsRequiringCharges; } }

        /// <summary>
        /// Указывает, отображаются ли заряды этого предмета в пользовательском интерфейсе.
        /// </summary>
        public bool IsDisplayingCharges { get { return BaseItem.IsDisplayingCharges; } }

        /// <summary>
        /// Указывает, скрыты ли заряды этого предмета в пользовательском интерфейсе.
        /// </summary>
        public bool IsHidingCharges { get { return BaseItem.IsHidingCharges; } }

        /// <summary>
        /// Указывает, можно ли убить этот предмет (для юнитов и других сущностей).
        /// </summary>
        public bool IsKillable { get { return BaseItem.IsKillable; } }

        /// <summary>
        /// Указывает, можно ли разобрать этот предмет на составные части.
        /// </summary>
        public bool IsDisassemblable { get { return BaseItem.IsDisassemblable; } }

        /// <summary>
        /// Указывает, может ли этот предмет поднимать оповещение или тревогу.
        /// </summary>
        public bool IsAlertable { get { return BaseItem.IsAlertable; } }

        /// <summary>
        /// Возвращает начальное количество зарядов предмета.
        /// </summary>
        public uint InitialCharges { get { return BaseItem.InitialCharges; } }

        /// <summary>
        /// Указывает, будет ли заклинание сразу применено при поднятии этого предмета.
        /// </summary>
        public bool IsCastedOnPickup { get { return BaseItem.IsCastedOnPickup; } }

        /// <summary>
        /// Возвращает текущее количество зарядов предмета.
        /// </summary>
        public override uint CurrentCharges { get { return BaseItem.CurrentCharges; } }

        /// <summary>
        /// Возвращает дополнительные заряды для этого предмета, если есть.
        /// </summary>
        public uint SecondaryCharges { get { return BaseItem.SecondaryCharges; } }

        /// <summary>
        /// Указывает, заблокировано ли объединение этого предмета с другими.
        /// </summary>
        public bool IsCombineLocked { get { return BaseItem.IsCombineLocked; } }

        /// <summary>
        /// Возвращает время покупки предмета.
        /// </summary>
        public float PurchaseTime { get { return BaseItem.PurchaseTime; } }

        /// <summary>
        /// Возвращает время, когда предмет был собран из составных частей.
        /// </summary>
        public float AssembledTime { get { return BaseItem.AssembledTime; } }

        /// <summary>
        /// Указывает, был ли этот предмет куплен, пока персонаж был мертв.
        /// </summary>
        public bool IsPurchasedWhileDead { get { return BaseItem.IsPurchasedWhileDead; } }

        /// <summary>
        /// Указывает, можно ли использовать этот предмет, не помещая его в инвентарь.
        /// </summary>
        public bool CanBeUsedOutOfInventory { get { return BaseItem.CanBeUsedOutOfInventory; } }

        /// <summary>
        /// Указывает, включен ли в данный момент этот предмет.
        /// </summary>
        public bool IsEnabled { get { return BaseItem.IsEnabled; } }

        /// <summary>
        /// Возвращает время включения этого предмета.
        /// </summary>
        public float EnableTime { get { return BaseItem.EnableTime; } }

        /// <summary>
        /// Возвращает ID персонажа, который купил этот предмет.
        /// </summary>
        public int PurchaserId { get { return BaseItem.PurchaserId; } }

        /// <summary>
        /// Возвращает стоимость этого предмета.
        /// </summary>
        public uint Cost { get { return BaseItem.Cost; } }

        /// <summary>
        /// Возвращает имя модели этого предмета.
        /// </summary>
        public string ModelName { get { return BaseItem.ModelName; } }

        /// <summary>
        /// Возвращает имя эффекта, связанного с этим предметом.
        /// </summary>
        public string EffectName { get { return BaseItem.EffectName; } }

        /// <summary>
        /// Перемещает предмет в указанный слот инвентаря.
        /// </summary>
        /// <param name="itemSlot">Слот для перемещения предмета.</param>
        /// <returns>Возвращает true, если операция успешна.</returns>
        public bool Move(ItemSlot itemSlot) { return BaseItem.Move(itemSlot); }

        /// <summary>
        /// Разбирает предмет на составные части.
        /// </summary>
        /// <returns>Возвращает true, если операция успешна.</returns>
        public bool Disassemble() { return BaseItem.Disassemble(); }

        /// <summary>
        /// Удаляет предмет из хранилища (Stash).
        /// </summary>
        /// <returns>Возвращает true, если операция успешна.</returns>
        public bool DropFromStash() { return BaseItem.DropFromStash(); }

        /// <summary>
        /// Продает предмет.
        /// </summary>
        /// <returns>Возвращает true, если операция успешна.</returns>
        public bool Sell() { return BaseItem.Sell(); }

        /// <summary>
        /// Блокирует возможность комбинирования предмета.
        /// </summary>
        /// <returns>Возвращает true, если операция успешна.</returns>
        public bool CombineLock() { return BaseItem.CombineLock(); }

        /// <summary>
        /// Снимает блокировку комбинирования предмета.
        /// </summary>
        /// <returns>Возвращает true, если операция успешна.</returns>
        public bool CombineUnlock() { return BaseItem.CombineUnlock(); }

        /// <summary>
        /// Сбрасывает предмет
        /// </summary>
        /// <returns>Возвращает true, если операция успешна.</returns>
        public bool HiddenDrop() { return BaseItem.HiddenDrop(); }

        /// <summary>
        /// Сбрасывает предмет, с возможностью поставить в очередь.
        /// </summary>
        /// <param name="queued">Определяет, должна ли операция быть поставлена в очередь.</param>
        /// <returns>Возвращает true, если операция успешна.</returns>
        public bool HiddenDrop(bool queued) { return BaseItem.HiddenDrop(queued); }

    }
}
