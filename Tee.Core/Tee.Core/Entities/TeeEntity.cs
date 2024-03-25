using Divine.Entity.Entities;
using Divine.Entity.Entities.Abilities.Items;
using Divine.Entity.Entities.Components;
using Divine.Entity.Entities.Units.Buildings;
using Divine.Numerics;
using Tee.Core.Entities.Abilities;
using Tee.Core.Utilities;

namespace Tee.Entities
{

    /// <summary>
    /// Класс TeeEntity представляет сущность на основе базовой сущности Entity.
    /// </summary>
    public class TeeEntity
    {
        /// <summary>
        /// Получает базовую сущность Entity.
        /// </summary>
        public Entity BaseEntity { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса TeeEntity.
        /// </summary>
        /// <param name="baseEntity">Базовая сущность.</param>
        /// <exception cref="ArgumentNullException">Бросается, если baseEntity равно null.</exception>
        public TeeEntity(Entity baseEntity)
        {
            BaseEntity = baseEntity ?? throw new ArgumentNullException(nameof(baseEntity));
        }
        public bool isValid
        {
            get
            {
                return BaseEntity.IsValid;
            }
        }
        /// <summary>
        /// Получает идентификатор сущности.
        /// </summary>
        public uint Handle
        {
            get
            {
                return BaseEntity.Handle;
            }
        }
        /// <summary>
        /// Получает сетевой идентификатор сущности.
        /// </summary>
        public uint NetworkHandle
        {
            get
            {
                return BaseEntity.NetworkHandle;
            }
        }
        /// <summary>
        /// Получает серийный номер сущности.
        /// </summary>
        public int Serial
        {
            get
            {
                return BaseEntity.Serial;
            }
        }
        /// <summary>
        /// Получает индекс сущности.
        /// </summary>
        public int Index
        {
            get
            {
                return BaseEntity.Index;
            }
        }
        /// <summary>
        /// Получает имя сущности.
        /// </summary>
        public string Name
        {
            get
            {
                return BaseEntity.Name;
            }
        }
        /// <summary>
        /// Получает сетевое имя сущности.
        /// </summary>
        public string NetworkName
        {
            get
            {
                return BaseEntity.NetworkName;
            }
        }
        /// <summary>
        /// Получает имя сущности, присвоенное дизайнером.
        /// </summary>
        public string DesignerName
        {
            get
            {
                return BaseEntity.DesignerName;
            }
        }

        /// <summary>
        /// Получает внутреннее имя сущности.
        /// </summary>
        public string InternalName
        {
            get
            {
                return BaseEntity.InternalName;
            }
        }
        /// <summary>
        /// Получает максимальное здоровье сущности.
        /// </summary>
        public int MaximumHealth
        {
            get
            {
                return BaseEntity.MaximumHealth;
            }
        }
        /// <summary>
        /// Получает текущее здоровье сущности.
        /// </summary>
        public int Health
        {
            get
            {
                return BaseEntity.Health;
            }
        }
        /// <summary>
        /// Получает время создания сущности.
        /// </summary>
        public float CreateTime
        {
            get
            {
                return BaseEntity.CreateTime;
            }
        }
        /// <summary>
        /// Получает скорость сущности.
        /// </summary>
        public float Speed
        {
            get
            {
                return BaseEntity.Speed;
            }
        }
        /// <summary>
        /// Получает команду сущности.
        /// </summary>
        public Team Team
        {
            get
            {
                return BaseEntity.Team;
            }
        }
        /// <summary>
        /// Получает владельца сущности.
        /// </summary>
        public TeeEntity? Owner
        {
            get
            {
                var baseOwner = BaseEntity.Owner;
                if (baseOwner == null)
                    return null;

                return (TeeEntity)baseOwner;
            }
        }

        /// <summary>
        /// Получает состояние жизни сущности.
        /// </summary>
        public LifeState LifeState
        {
            get
            {
                return BaseEntity.LifeState;
            }
        }
        /// <summary>
        /// Получает ID класса сущности.
        /// </summary>
        public ClassId ClassId
        {
            get
            {
                return BaseEntity.ClassId;
            }
        }
        /// <summary>
        /// Получает сетевой ID класса сущности.
        /// </summary>
        public int ClassNetworkId
        {
            get
            {
                return BaseEntity.ClassNetworkId;
            }
        }
        /// <summary>
        /// Получает текущую позицию сущности в 3D пространстве.
        /// </summary>
        public Vector3 Position
        {
            get
            {
                return BaseEntity.Position;
            }
        }

        /// <summary>
        /// Получает углы поворота сущности в 3D пространстве.
        /// </summary>
        public Vector3 Angles
        {
            get
            {
                return BaseEntity.Angles;
            }
        }

        /// <summary>
        /// Получает сетевые углы поворота сущности.
        /// </summary>
        public Vector3 NetworkAngles
        {
            get
            {
                return BaseEntity.NetworkAngles;
            }
        }

        /// <summary>
        /// Проверяет, жива ли сущность.
        /// </summary>
        public bool IsAlive
        {
            get
            {
                return BaseEntity.IsAlive;
            }
        }

        /// <summary>
        /// Проверяет, видима ли сущность.
        /// </summary>
        public bool IsVisible
        {
            get
            {
                return BaseEntity.IsVisible;
            }
        }

        /// <summary>
        /// Проверяет, находится ли сущность в состоянии "сна" (dormant).
        /// </summary>
        public bool IsDormant
        {
            get
            {
                return BaseEntity.IsDormant;
            }
        }

        /// <summary>
        /// Получает угол поворота сущности в градусах.
        /// </summary>
        public float Rotation
        {
            get
            {
                return BaseEntity.Rotation;
            }
        }

        /// <summary>
        /// Получает угол поворота сущности в радианах.
        /// </summary>
        public float RotationRad
        {
            get
            {
                return BaseEntity.RotationRad;
            }
        }

        /// <summary>
        /// Получает сетевой угол поворота сущности в градусах.
        /// </summary>
        public float NetworkRotation
        {
            get
            {
                return BaseEntity.NetworkRotation;
            }
        }

        /// <summary>
        /// Получает сетевой угол поворота сущности в радианах.
        /// </summary>
        public float NetworkRotationRad
        {
            get
            {
                return BaseEntity.NetworkRotationRad;
            }
        }

        /// <summary>
        /// Получает имя текущей анимации сущности.
        /// </summary>
        public string AnimationName
        {
            get
            {
                return BaseEntity.AnimationName;
            }
        }

        /// <summary>
        /// Получает или устанавливает модель сущности.
        /// </summary>
        public string Model
        {
            get
            {
                return BaseEntity.Model;
            }
            set
            {
                BaseEntity.Model = value;
            }
        }

        /// <summary>
        /// Получает или устанавливает масштаб сущности.
        /// </summary>
        public float Scale
        {
            get
            {
                return BaseEntity.Scale;
            }
            set
            {
                BaseEntity.Scale = value;
            }
        }

        /// <summary>
        /// Получает или устанавливает цветовую окраску сущности.
        /// </summary>
        public Color ColorTint
        {
            get
            {
                return BaseEntity.ColorTint;
            }
            set
            {
                BaseEntity.ColorTint = value;
            }
        }

        /// <summary>
        /// Получает или устанавливает цвет свечения сущности.
        /// </summary>
        public Color Glow
        {
            get
            {
                return BaseEntity.Glow;
            }
            set
            {
                BaseEntity.Glow = value;
            }
        }

        public static explicit operator TeeEntity(Entity item)
        {
            if (item == null) return null;
            return TeeEntityManager.GetTeeEntityByHandle(item.Handle) ?? TeeEntityManager.Create(item);
        }

        public static explicit operator Entity(TeeEntity v)
        {
            return v.BaseEntity;
        }
    }
}
