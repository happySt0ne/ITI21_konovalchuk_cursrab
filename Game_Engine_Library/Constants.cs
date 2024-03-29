﻿namespace Game_Engine_Library {
    /// <summary>
    /// Класс, содержащий все константы, используемые в игре.
    /// </summary>
    public static class Constants {
        /// <summary>
        /// Интервал таймера в секундах.
        /// </summary>
        public const double TIMER_INTERVAL_SECONDS = 0.025;

        /// <summary>
        /// Шанс создать бонус каждый кадр = 1 / на это значение.
        /// </summary>
        public const int CHANCE_TO_CREATE_BONUS_PER_FRAME = 20;

        public const int PANZAR_MAX_HP = 100;
        public const double PANZARS_WIDTH = 0.3;
        public const double PANZARS_HEIGHT = 0.3;
        public const double PANZARS_SPEED = 0.006;
        public const double HEIGHT_TO_CREATE_PANZARS = -0.7;
        public const double PANZAR_X_COORDINATE_SPAWNPOINT = 0.5;

        public const int MUZZLE_ROTATION_SPEED = 5;
        public const int MUZZLE_MAX_ROTATE = 70;
        public const int MUZZLE_MIN_ROTATE = 0;
        public const double MAX_COOLDOWN = 3;
        public const int START_AMMO = 10;

        public const double BONUS_WIDTH = 0.08;
        public const double BONUS_HEIGHT = 0.08;
        public const double BONUS_Y_SPEED = 0.04;
        public const double REDUCE_COOLDOWN_BONUS_DURATION = 3;
        public const int AMMO_EFFECT_GIVEN_AMMUNITION = 5;
        public const int HEAL_EFFECT_GIVEN_HEALTH = 20;

        public const double BULLETS_X_START_SPEED = 0.07;
        public const double BULLETS_Y_START_SPEED = 0.07;
        public const double GRAVITY_SCALE = -0.006;
        public const double BULLETS_HEIGHT = 0.05;
        public const double BULLETS_WIDTH = 0.05;
        public const int BULLET_DAMAGE = 10;

        public const double PLANE_X_COORDINATE_SPAWN = -1.3;
        public const double PLANE_Y_COORDINATE_SPAWN = 0.7;
        public const double PLANE_HEIGHT = 0.3;
        public const double PLANE_WIDTH = 0.4;
        public const double PLANE_X_SPEED = 0.015;
        public const double PLANE_SPAWN_MAX_COOLDOWN = 5;

        public const string PANZAR_MUZZLE_TEXTURE_PATH = @"../../../Game_Engine_Library/Resources/PanzarMuzzle.bmp";
        public const string PANZAR_TURRET_TEXTURE_PATH = @"../../../Game_Engine_Library/Resources/PanzarTurret.bmp";
        public const string PANZAR_TRACK_TEXTURE_PATH = @"../../../Game_Engine_Library/Resources/PanzarTrack.bmp";
        public const string BULLET_TEXTURE_PATH = @"../../../Game_Engine_Library/Resources/Bullet.bmp";
        public const string WALL_TEXTURE_PATH = @"../../../Game_Engine_Library/Resources/Mountain.bmp";
        public const string BACKGROUND_TEXTURE_PATH = @"../../../Game_Engine_Library/Resources/Background2.bmp";
        public const string PLANE_TEXTURE_PATH = @"../../../Game_Engine_Library/Resources/Plane.bmp";
        public const string HEAL_BONUS_TEXTURE_PATH = @"../../../Game_Engine_Library/Resources/HealBonus.bmp";
        public const string AMMO_BONUS_TEXTURE_PATH = @"../../../Game_Engine_Library/Resources/Ammo.bmp";
        public const string REDUCE_COOLDOWN_BONUS_TEXTURE_PATH = @"../../../Game_Engine_Library/Resources/ReduceCooldownBonus.bmp";
    }
}
